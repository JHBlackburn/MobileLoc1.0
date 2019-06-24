using MediatR;
using Microsoft.AspNetCore.Mvc;
using MobileLoc.Automotive.Domain.Queries;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Api.Controllers
{
    public class CarController : Controller
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("automotive/makes")]
        public async Task<IActionResult> GetMakes()
        {
            var getMakesRequest = new GetMakes();
            var results = await _mediator.Send(getMakesRequest);
            return Ok(results);
        }

        [HttpGet("automotive/make/{makeId}/models")]
        public async Task<IActionResult> GetModels(int makeId)
        {
            var getModelsRequest = new GetModels(makeId);
            var results = await _mediator.Send(getModelsRequest);
            return Ok(results);
        }

        [HttpGet("automotive/model/{modelId}/years")]
        public async Task<IActionResult> GetYears(int modelId)
        {
            var getYearsRequest = new GetYears(modelId);
            var results = await _mediator.Send(getYearsRequest);
            return Ok(results);
        }
    }
}