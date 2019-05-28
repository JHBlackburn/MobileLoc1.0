using MobileLoc.Automotive.Api.Interfaces;
using MobileLoc.Automotive.Api.Models.SqlServer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Api.Repositories
{
    public class LookupRepository : ILookupRepository
    {
        private readonly MobileLocContext _mobileLocContext;

        public LookupRepository(MobileLocContext mobileLocContext)
        {
            _mobileLocContext = mobileLocContext;
        }

        public async Task<IEnumerable<CarMake>> GetCarMakesAsync()
        {
            return _mobileLocContext.CarMake.Where(m => m.IsActive == true);
        }
    }
}