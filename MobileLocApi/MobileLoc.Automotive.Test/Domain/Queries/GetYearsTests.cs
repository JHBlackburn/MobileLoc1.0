using FluentAssertions;
using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Domain.Interfaces;
using MobileLoc.Automotive.Domain.Queries;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MobileLoc.Automotive.Test.Domain.Queries
{
    public class GetYearsTests
    {
        [Fact]
        public async Task Handle_GivenModelId_ReturnsExpectedYears()
        {
            // arrange
            var modelId = 132;
            var request = new GetYears(modelId);
            var lookupRepo = new Mock<ILookupRepository>();
            var handler = new GetYearsHandler(lookupRepo.Object);
            var expectedResults = new List<GetYearsDto>
            {
                new GetYearsDto
                {
                    CarYearId = 1,
                    CarYear = "1901",
                    CarModelId = modelId,
                    IsActive = true,
                },
            };
            lookupRepo.Setup(repo => repo.GetActiveYearsByModelAsync(It.IsAny<int>())).ReturnsAsync(expectedResults);

            // act
            var results = await handler.Handle(request, new CancellationToken());

            //assert
            results.Should().BeEquivalentTo(expectedResults);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public async Task Constructor_GivenNoModelId_ThrowsArgumentException(int initializedModelId)
        {
            // act and assert
            var exception = Assert.Throws<ArgumentException>(() => new GetYears(initializedModelId));
        }
    }
}