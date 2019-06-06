using MediatR;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetMake : IRequest<GetMake>
    {
        public int CarMakeId { get; }

        public string CarMakeName { get; }

        public bool? IsActive { get; }

        public GetMake(int carMakeId, string carMakeName, bool? isActive)
        {
            CarMakeId = carMakeId;
            CarMakeName = carMakeName;
            IsActive = isActive;
        }
    }
}