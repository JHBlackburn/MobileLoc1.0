using System;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer
{
    public partial class CarModel
    {
        public int CarModelId { get; set; }
        public string CarModelName { get; set; }
        public int CarMakeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual CarMake CarMake { get; set; }
    }
}