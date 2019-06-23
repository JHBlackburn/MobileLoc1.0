using MobileLoc.Automotive.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Domain.Interfaces
{
    public interface ILookupRepository
    {
        Task<IEnumerable<GetMakesDto>> GetActiveMakesAsync();

        Task<IEnumerable<GetModelsDto>> GetActiveModelsByMakeAsync(int carMakeId);
    }
}