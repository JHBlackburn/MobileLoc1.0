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

        public async Task<IEnumerable<GetModelsDto>> GetActiveModelsByMakeAsync(int carMakeId)
        {
            var dbResults = _mobileLocContext.CarModel.Where(model => model.IsActive.Value && model.CarMakeId == carMakeId);

            return dbResults.Select(m => new GetModelsDto
            {
                CarModelId = m.CarModelId,
                CarModelName = m.CarModelName,
                CarMakeId = m.CarMakeId,
                IsActive = m.IsActive,
            });
        }

        public async Task<IEnumerable<GetModelsDto>> GetActiveYearsByModelAsync(int carModelId)
        {
            throw new System.NotImplementedException();
        }
    }
}