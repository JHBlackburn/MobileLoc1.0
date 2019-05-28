using Microsoft.AspNetCore.Mvc;

namespace MobileLoc.Automotive.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetModelByMake(int id)
        {
            return "value";
        }
    }
}