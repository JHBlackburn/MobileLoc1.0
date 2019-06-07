using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Persistence.Repositories
{
    public class LookupRepository
    {
        private MobilelocContext _mobileLocContext { get; set; }

        public LookupRepository(MobilelocContext mobileLocContext)
        {
            _mobileLocContext = mobileLocContext;
        }

        public async Task<IEnumerable<GetMakesDto>> GetActiveMakesAsync()
        {
            return null;
        }
    }
}