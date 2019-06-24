using MediatR;
using MobileLoc.Automotive.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileLoc.Automotive.Domain.Queries
{
    public class GetYears : IRequest<IEnumerable<GetYearsDto>>
    {
        public int ModelId;

        public GetYears(int modelId)
        {
            ModelId = modelId;

            Validate();
        }

        private void Validate()
        {
            var errorsList = new StringBuilder();

            if (ModelId <= 0)
            {
                errorsList.Append($"Invalid value provided for {nameof(ModelId)}");
            }

            if (errorsList.Length > 0)
            {
                throw new ArgumentException(errorsList.ToString());
            }
        }
    }
}