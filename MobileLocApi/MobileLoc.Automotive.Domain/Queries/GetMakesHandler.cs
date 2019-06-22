using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetMakesHandler : IRequestHandler<GetMakes, IEnumerable<GetMakesDto>>
    {
        private ILookupRepository _lookupRepository { get; set; }

        public GetMakesHandler(ILookupRepository lookupRepository)
        {
            _lookupRepository = lookupRepository;
        }

        public async Task<IEnumerable<GetMakesDto>> Handle(GetMakes request, CancellationToken cancellationToken)
        {
            var results = await _lookupRepository.GetActiveMakesAsync();
            return results;
        }
    }
}