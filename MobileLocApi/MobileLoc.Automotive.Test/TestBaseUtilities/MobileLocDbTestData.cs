﻿using MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Test.TestBaseUtilities
{
    public class MobileLocDbTestData
    {
        private MobilelocContext _mobileLocContext;

        public MobileLocDbTestData(MobilelocContext mobileLocContext)
        {
            mobileLocContext = _mobileLocContext;
        }

        public void Initialize()
        {
            InitializeCarMakes();
            _mobileLocContext.SaveChanges();
        }

        private void InitializeCarMakes()
        {
            _mobileLocContext.CarMake.AddRange(

                new List<CarMake>
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
                        IsActive = true,
                    },
                    new CarMake
                    {
                        CarMakeId = 5,
                        CarMakeName = "DrainsOrDropsGreaseEverywhere",
                        IsActive = true,
                    },
                });
        }
    }
}