using FluentAssertions;
using MobileLoc.Automotive.Api.Models.SqlServer;
using MobileLoc.Automotive.Api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MobileLoc.Automotive.Test.Repositories
{
    public class LookupRepositoryTests : TestBase
    {
        [Fact]
        public async Task GetCarMakesAsync_ReturnsListOfMakes()
        {
            //arrange
            var lookupRepo = new LookupRepository(TestDbContext);
            var expectedMakes = new List<CarMake>
            {
                new CarMake
                {
                    CarMakeId = 1,
                    CarMakeName = "Ford",
                },
                new CarMake
                {
                    CarMakeId = 2,
                    CarMakeName = "Chevrolet",
                },
                new CarMake
                {
                    CarMakeId = 3,
                    CarMakeName = "BMW",
                },
            };

            //act
            var results = lookupRepo.GetCarMakesAsync();

            //assert
            results.Should().BeEquivalentTo(expectedMakes);
        }
    }
}