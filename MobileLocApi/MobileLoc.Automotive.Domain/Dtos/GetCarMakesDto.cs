namespace MobileLoc.Automotive.Domain.Dtos
{
    public class GetCarMakesDto
    {
        public int CarMakeId { get; set; }
        public string CarMakeName { get; set; }
        public bool? IsActive { get; set; }
    }
}