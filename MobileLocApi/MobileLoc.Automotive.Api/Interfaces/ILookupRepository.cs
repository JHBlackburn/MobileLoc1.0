using MobileLoc.Automotive.Api.Models.SqlServer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Api.Interfaces
{
    public interface ILookupRepository
    {
        Task<IEnumerable<CarMake>> GetCarMakesAsync();
    }
}