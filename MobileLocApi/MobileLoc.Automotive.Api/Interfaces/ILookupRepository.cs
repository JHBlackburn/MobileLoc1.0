using System.Threading.Tasks;

namespace MobileLoc.Automotive.Api.Interfaces
{
    public interface ILookupRepository 
    {
        Task GetCarMakesAsync();
    }
}