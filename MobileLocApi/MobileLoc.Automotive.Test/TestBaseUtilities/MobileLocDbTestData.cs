using MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer;
using System;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Test.TestBaseUtilities
{
    public class MobileLocDbTestData
    {
        private MobilelocContext _mobileLocContext;

        public MobileLocDbTestData(MobilelocContext mobileLocContext)
        {
            _mobileLocContext = mobileLocContext;
        }

        public void Initialize()
        {
            InitializeCarMakes();
            InitializeCarModels();
            InitializeCarYears();
            InitializeSystemUsers();
            InitializeCars();

            _mobileLocContext.SaveChanges();
        }

        private void InitializeCarMakes()
        {
            var data = new List<CarMake>
                {
                    new CarMake
                    {
                        CarMakeId = 1,
                        CarMakeName = "FixOrRepairDaily",
                        IsActive = true,
                    },
                    new CarMake
                    {
                        CarMakeId = 2,
                        CarMakeName = "CannotHaveExpensiveVehicleYet",
                        IsActive = true,
                    },
                    new CarMake
                    {
                        CarMakeId = 3,
                        CarMakeName = "ProofOfRichSpoiledChildrenHavingEverything",
                        IsActive = true,
                    },
                    new CarMake
                    {
                        CarMakeId = 4,
                        CarMakeName = "TooOftenYankeesOverpriceThisAuto",
                        IsActive = false,
                    },
                    new CarMake
                    {
                        CarMakeId = 5,
                        CarMakeName = "DrainsOrDropsGreaseEverywhere",
                        IsActive = false,
                    },
                };

            _mobileLocContext.CarMake.AddRange(data);
        }

        private void InitializeCarModels()
        {
            var data = new List<CarModel>
                {
                    new CarModel
                    {
                        CarModelId = 1,
                        CarModelName = "Mustang",
                        CarMakeId = 1,
                        IsActive = true,
                    },
                    new CarModel
                    {
                        CarModelId = 2,
                        CarModelName = "F-150",
                        CarMakeId = 1,
                        IsActive = false,
                    },
                    new CarModel
                    {
                        CarModelId = 3,
                        CarModelName = "Transit Van",
                        CarMakeId = 1,
                        IsActive = true,
                    },
                    new CarModel
                    {
                        CarModelId = 4,
                        CarModelName = "Corvette",
                        CarMakeId = 2,
                        IsActive = true,
                    },
                    new CarModel
                    {
                        CarModelId = 5,
                        CarModelName = "Caprice",
                        CarMakeId = 2,
                        IsActive = false,
                    },
                };

            _mobileLocContext.CarModel.AddRange(data);
        }

        private void InitializeCarYears()
        {
            var data = new List<CarYear>
                {
                    new CarYear
                    {
                        CarYearId = 1,
                        CarYear1 = "1901",
                        IsActive = true,
                    },
                    new CarYear
                    {
                        CarYearId = 2,
                        CarYear1 = "1902",
                        IsActive = true,
                    },
                    new CarYear
                    {
                        CarYearId = 3,
                        CarYear1 = "1903",
                        IsActive = true,
                    },
                    new CarYear
                    {
                        CarYearId = 4,
                        CarYear1 = "1904",
                        IsActive = true,
                    },
                    new CarYear
                    {
                        CarYearId = 5,
                        CarYear1 = "1905",
                        IsActive = true,
                    },
                };

            _mobileLocContext.CarYear.AddRange(data);
        }

        private void InitializeSystemUsers()
        {
            var data = new List<SystemUser>
                {
                    new SystemUser
                    {
                        SystemUserId = 99,
                        SystemUserParentId = 99,
                        SystemUserName = "Test@Testington.com",
                        SystemUserType = "Employee",
                    }
            };

            _mobileLocContext.AddRange(data);
        }

        private void InitializeCars()
        {
            var data = new List<Car>
                {
                    new Car
                    {
                        CarMakeId = 1,
                        CarModelId = 1,
                        CarYearId = 1,
                        InsertBy = 99,
                        InsertDt = DateTime.Parse("1/1/1900"),
                        UpdateBy = 99,
                        UpdateDt = DateTime.Parse("1/1/1900"),
                    },
                    new Car
                    {
                        CarMakeId = 2,
                        CarModelId = 2,
                        CarYearId = 2,
                        InsertBy = 99,
                        InsertDt = DateTime.Parse("1/2/1900"),
                        UpdateBy = 99,
                        UpdateDt = DateTime.Parse("1/2/1900"),
                    },
                    new Car
                    {
                        CarMakeId = 3,
                        CarModelId = 3,
                        CarYearId = 3,
                        InsertBy = 99,
                        InsertDt = DateTime.Parse("1/3/1900"),
                        UpdateBy = 99,
                        UpdateDt = DateTime.Parse("1/3/1900"),
                    },
                };

            _mobileLocContext.Car.AddRange(data);
        }
    }
}