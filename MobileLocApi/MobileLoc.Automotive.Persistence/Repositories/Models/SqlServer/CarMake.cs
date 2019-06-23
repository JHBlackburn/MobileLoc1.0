using System;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer
{
    public partial class CarMake
    {
        public CarMake()
        {
            CarModel = new HashSet<CarModel>();
        }

        public int CarMakeId { get; set; }
        public string CarMakeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CarModel> CarModel { get; set; }
    }
}