using MediatR;
using Microsoft.AspNetCore.Mvc;
using MobileLoc.Automotive.Domain.Queries;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Api.Controllers
{
    public class CarController : Controller
    {
        private readonly IMediator mediator;

        [HttpGet("automotive/makes")]
        public async Task<IActionResult> GetMakes()
        {
            var getMakesRequest = new GetMakes();
            await mediator.Send(getMakesRequest);
            return Ok("Hello World");
        }
    }
}