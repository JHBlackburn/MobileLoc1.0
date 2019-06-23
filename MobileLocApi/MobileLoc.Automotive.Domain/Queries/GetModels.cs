using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetModels : IRequest<IEnumerable<GetModelsDto>>
    {
        public int MakeId { get; }

        public GetModels(int makeId)
        {
            MakeId = makeId;

            Validate();
        }

        private void Validate()
        {
            var errorsList = new StringBuilder();

            if (MakeId <= 0)
            {
                errorsList.Append($"Invalid value provided for {nameof(MakeId)}");
            }

            if (errorsList.Length > 0)
            {
                throw new ArgumentException(errorsList.ToString());
            }
        }
    }
}