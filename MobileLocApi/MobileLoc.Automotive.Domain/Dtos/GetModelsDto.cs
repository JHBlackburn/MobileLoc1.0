namespace MobileLoc.Automotive.Domain.Dtos
{
    public class GetModelsDto
    {
        public int CarModelId { get; set; }
        public string CarModelName { get; set; }
        public int? CarMakeId { get; set; }
        public bool? IsActive { get; set; }
    }
}