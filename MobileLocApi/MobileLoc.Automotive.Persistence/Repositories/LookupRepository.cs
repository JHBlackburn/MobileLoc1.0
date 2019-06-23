using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Domain.Interfaces;
using MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Persistence.Repositories
{
    public class LookupRepository : ILookupRepository
    {
        private MobilelocContext _mobileLocContext { get; set; }

        public LookupRepository(MobilelocContext mobileLocContext)
        {
            _mobileLocContext = mobileLocContext;
        }

        public async Task<IEnumerable<GetMakesDto>> GetActiveMakesAsync()
        {
            var dbResults = _mobileLocContext.CarMake.Where(make => make.IsActive.Value);

            return dbResults.Select(m => new GetMakesDto
            {
                CarMakeId = m.CarMakeId,
                CarMakeName = m.CarMakeName,
                IsActive = m.IsActive,
            });
        }
    }
}