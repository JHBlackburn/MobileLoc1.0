using FluentAssertions;
using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Domain.Interfaces;
using MobileLoc.Automotive.Domain.Queries;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MobileLoc.Automotive.Test.Domain.Queries
{
    public class GetMakesTests
    {
        [Fact]
        public async Task Handle_GivenNoParameters_ReturnsExpectedMakes()
        {
            //arrange
            var request = new GetMakes();
            var lookupRepo = new Mock<ILookupRepository>();
            var handler = new GetMakesHandler(lookupRepo.Object);

            var expectedResults = new List<GetMakesDto>
            {
                new GetMakesDto
                {
                    CarMakeId = 1,
                    CarMakeName = "Ford",
                },
                new GetMakesDto
                {
                    CarMakeId = 2,
                    CarMakeName = "Chevrolet",
                },
            };
            lookupRepo.Setup(x => x.GetActiveMakesAsync()).ReturnsAsync(expectedResults);

            //act
            var results = await handler.Handle(request, new CancellationToken());

            //assert
            results.Should().BeEquivalentTo(expectedResults);
        }
    }
}