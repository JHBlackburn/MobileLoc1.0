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

        [Fact]
        public async Task GetActiveModelsByMakeAsync_GivenMake_ReturnsOnlyActiveModelsFromContext()
        {
            // arrange
            var lookupRepo = new LookupRepository(TestMobileLocContext);
            var carMakeId = 1;

            var expectedResults = new List<GetModelsDto>
            {
                new GetModelsDto
                    {
                        CarModelId = 1,
                        CarModelName = "Mustang",
                        CarMakeId = 1,
                        IsActive = true,
                    },
                    new GetModelsDto
                    {
                        CarModelId = 3,
                        CarModelName = "Transit Van",
                        CarMakeId = 1,
                        IsActive = true,
                    },
            };

            // act
            var results = await lookupRepo.GetActiveModelsByMakeAsync(carMakeId);

            // assert
            results.Should().BeEquivalentTo(expectedResults);
        }

        [Fact]
        public async Task GetActiveYearsByModelAsync_GivenModel_ReturnsOnlyActiveYearsFromContext()
        {
            // arrange
            var lookupRepo = new LookupRepository(TestMobileLocContext);
            var carModelId = 1;

            var expectedResults = new List<GetYearsDto>
            {
                new GetYearsDto
                    {
                        CarYearId = 1,
                        CarYear = "1901",
                        CarModelId = 1,
                        IsActive = true,
                    },
            };

            // act
            var results = await lookupRepo.GetActiveYearsByModelAsync(carModelId);

            // assert
            results.Should().BeEquivalentTo(expectedResults);
        }
    }
}