using System.Collections.Generic;

namespace MobileLoc.Automotive.Api.Models.SqlServer
{
    public partial class CarMake
    {
        public CarMake()
        {
            Car = new HashSet<Car>();
            CarModel = new HashSet<CarModel>();
        }

        public int CarMakeId { get; set; }
        public string CarMakeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Car> Car { get; set; }
        public virtual ICollection<CarModel> CarModel { get; set; }
    }
}