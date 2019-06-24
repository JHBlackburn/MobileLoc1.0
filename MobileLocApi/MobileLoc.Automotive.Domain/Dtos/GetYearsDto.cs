namespace MobileLoc.Automotive.Domain.Dtos
{
    public class GetYearsDto
    {
        public int CarYearId { get; set; }
        public string CarYear { get; set; }
        public int CarModelId { get; set; }
        public bool? IsActive { get; set; }
    }
}