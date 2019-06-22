using FluentAssertions;
using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MobileLoc.Automotive.Test.Persistence.Repositories
{
    public class LookupRepositoryTests : PersistenceTestBase
    {
        [Fact]
        public async Task GetActiveMakesAsync_ReturnsOnlyActiveMakesFromContext()
        {
            // arrange
            var lookupRepo = new LookupRepository(TestMobileLocContext);
            var expectedResults = new List<GetMakesDto>
            {
                new GetMakesDto
                    {
                        CarMakeId = 1,
                        CarMakeName = "FixOrRepairDaily",
                        IsActive = true,
                    },
                    new GetMakesDto
                    {
                        CarMakeId = 2,
                        CarMakeName = "CannotHaveExpensiveVehicleYet",
                        IsActive = true,
                    },
                    new GetMakesDto
                    {
                        CarMakeId = 3,
                        CarMakeName = "ProofOfRichSpoiledChildrenHavingEverything",
                        IsActive = true,
                    },
            };

            // act
            var results = await lookupRepo.GetActiveMakesAsync();

            // assert
            results.Should().BeEquivalentTo(expectedResults);
        }
    }
}