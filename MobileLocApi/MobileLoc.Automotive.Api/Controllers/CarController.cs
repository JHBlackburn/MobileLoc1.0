using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MobileLoc.Automotive.Api.Controllers
{
    public class CarController : Controller
    {
        [Route("automotive/makes")]
        public async Task<IActionResult> GetMakes()
        {
            return Ok();
        }
    }
}