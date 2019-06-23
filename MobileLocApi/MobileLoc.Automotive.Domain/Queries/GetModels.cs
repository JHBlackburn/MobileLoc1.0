using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetModels : IRequest<IEnumerable<GetModelsDto>>
    {
        public int MakeId { get; }

        public GetModels(int makeId)
        {
            MakeId = makeId;
        }
    }
}