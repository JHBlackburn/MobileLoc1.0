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
    }
}