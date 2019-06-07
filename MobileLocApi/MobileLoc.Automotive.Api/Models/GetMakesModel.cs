namespace MobileLoc.Automotive.Api.Models
{
    public class GetMakesModel
    {
        public int CarMakeId { get; set; }
        public string CarMakeName { get; set; }
        public bool? IsActive { get; set; }
    }
}