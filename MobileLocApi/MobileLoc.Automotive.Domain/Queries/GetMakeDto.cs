namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetMakeDto
    {
        public int CarMakeId { get; set; }
        public string CarMakeName { get; set; }
        public bool? IsActive { get; set; }
    }
}