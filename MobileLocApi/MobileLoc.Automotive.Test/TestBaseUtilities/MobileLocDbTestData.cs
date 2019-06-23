using MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer;
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
    }
}