using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetYearsHandler : IRequestHandler<GetYears, IEnumerable<GetYearsDto>>
    {
        private readonly ILookupRepository _lookupRepository;

        public GetYearsHandler(ILookupRepository lookupRepository)
        {
            _lookupRepository = lookupRepository;
        }

        public async Task<IEnumerable<GetYearsDto>> Handle(GetYears request, CancellationToken cancellationToken)
        {
            return await _lookupRepository.GetActiveYearsByModelAsync(request.ModelId);
        }
    }
}