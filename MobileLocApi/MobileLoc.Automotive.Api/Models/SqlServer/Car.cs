using System;

namespace MobileLoc.Automotive.Api.Models.SqlServer

{
    public partial class Car
    {
        public int CarId { get; set; }
        public int CarMakeId { get; set; }
        public int CarModelId { get; set; }
        public int CarYearId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime InsertDt { get; set; }
        public int InsertBy { get; set; }
        public DateTime UpdateDt { get; set; }
        public int UpdateBy { get; set; }
        public byte[] ChangeVersion { get; set; }

        public virtual CarMake CarMake { get; set; }
        public virtual CarModel CarModel { get; set; }
        public virtual CarYear CarYear { get; set; }
    }
}