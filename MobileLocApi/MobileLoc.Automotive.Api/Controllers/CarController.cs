using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Api.Controllers
{
    public class CarController : Controller
    {
        [Route("automotive/make")]
        public async Task<IActionResult> GetCarMakes()
        {
            return Ok();
        }
    }
}