using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetModelsHandler : IRequestHandler<GetModels, IEnumerable<GetModelsDto>>
    {
        public async Task<IEnumerable<GetModelsDto>> Handle(GetModels request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}