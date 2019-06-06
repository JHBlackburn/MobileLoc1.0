using System;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer
{
    public partial class CarMake
    {
        public int CarMakeId { get; set; }
        public string CarMakeName { get; set; }
        public bool? IsActive { get; set; }
    }
}