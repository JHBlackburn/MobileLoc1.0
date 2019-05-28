using MobileLoc.Automotive.Api.Interfaces;
using MobileLoc.Automotive.Api.Models.SqlServer;
using System;
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

        public Task GetCarMakesAsync()
        {
            throw new NotImplementedException();
        }
    }
}