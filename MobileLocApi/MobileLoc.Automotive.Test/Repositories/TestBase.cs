using Microsoft.EntityFrameworkCore;
using MobileLoc.Automotive.Api.Models.SqlServer;
using System;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Test.Repositories
{
    public class TestBase
    {
        public readonly MobileLocContext TestDbContext;

        public TestBase()
        {
            var options = new DbContextOptionsBuilder<MobileLocContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;

            TestDbContext = new MobileLocContext(options);

            CreateInMemoryTestData();
        }

        private void CreateInMemoryTestData()
        {
            CarMakes();
            TestDbContext.SaveChanges();
        }

        private void CarMakes()
        {
            var carMakes = new List<CarMake>
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
            TestDbContext.Add(carMakes);
        }
    }
}