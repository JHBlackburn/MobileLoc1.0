using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetModels : IRequest<IEnumerable<GetModelsDto>>
    {
        private readonly int _makeId;

        public GetModels(int makeId)
        {
            _makeId = makeId;
        }
    }
}