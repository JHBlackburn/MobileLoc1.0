using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetModelsHandler : IRequestHandler<GetModels, IEnumerable<GetModelsDto>>
    {
        private ILookupRepository _lookupRepository;

        public GetModelsHandler(ILookupRepository lookupRepository)
        {
            _lookupRepository = lookupRepository;
        }

        public async Task<IEnumerable<GetModelsDto>> Handle(GetModels request, CancellationToken cancellationToken)
        {
            return await _lookupRepository.GetActiveModelsByMakeAsync(request.MakeId);
        }
    }
}