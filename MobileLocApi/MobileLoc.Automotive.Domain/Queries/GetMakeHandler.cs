using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetMakeHandler : IRequestHandler<GetMake, IEnumerable<GetMakeDto>>
    {
        public Task<IEnumerable<GetMakeDto>> Handle(GetMake request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}