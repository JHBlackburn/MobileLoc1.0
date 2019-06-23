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
    public class GetModelsTests
    {
        [Fact]
        public async Task Handle_GivenMakeId_ReturnsExpectedModels()
        {
            // arrange
            var makeId = 45;
            var request = new GetModels(makeId);
            var lookupRepo = new Mock<ILookupRepository>();
            var handler = new GetModelsHandler(lookupRepo.Object);
            var expectedResults = new List<GetModelsDto>
            {
                new GetModelsDto
                {
                    CarModelId = 1,
                    CarModelName = "Obscure Car Model - 1000",
                    CarMakeId = 45,
                    IsActive = true,
                },
            };
            lookupRepo.Setup(repo => repo.GetActiveModelsByMakeAsync(It.IsAny<int>())).ReturnsAsync(expectedResults);

            // act
            var results = await handler.Handle(request, new CancellationToken());

            //assert
            results.Should().BeEquivalentTo(expectedResults);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public async Task Constructor_GivenNoMakeId_ThrowsArgumentException(int initializedMakeId)
        {
            // act and assert
            var exception = Assert.Throws<ArgumentException>(() => new GetModels(initializedMakeId));
        }
    }
}