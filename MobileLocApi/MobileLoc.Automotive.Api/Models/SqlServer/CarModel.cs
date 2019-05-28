using System.Collections.Generic;

namespace MobileLoc.Automotive.Api.Models.SqlServer
{
    public partial class CarModel
    {
        public CarModel()
        {
            Car = new HashSet<Car>();
        }

        public int CarModelId { get; set; }
        public string CarModelName { get; set; }
        public int CarMakeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual CarMake CarMake { get; set; }
        public virtual ICollection<Car> Car { get; set; }
    }
}