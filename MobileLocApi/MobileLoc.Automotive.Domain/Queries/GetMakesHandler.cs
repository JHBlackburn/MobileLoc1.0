using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetMakesHandler : IRequestHandler<GetMakes, IEnumerable<GetMakesDto>>
    {
        public Task<IEnumerable<GetMakesDto>> Handle(GetMakes request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}