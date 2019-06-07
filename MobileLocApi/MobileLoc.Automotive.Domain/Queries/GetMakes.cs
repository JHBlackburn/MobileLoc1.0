using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetMakes : IRequest<IEnumerable<GetMakesDto>>
    {
    }
}