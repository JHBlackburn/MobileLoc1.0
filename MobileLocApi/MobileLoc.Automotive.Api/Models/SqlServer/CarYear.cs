using System.Collections.Generic;

namespace MobileLoc.Automotive.Api.Models.SqlServer
{
    public partial class CarYear
    {
        public CarYear()
        {
            Car = new HashSet<Car>();
        }

        public int CarYearId { get; set; }
        public string CarYear1 { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}