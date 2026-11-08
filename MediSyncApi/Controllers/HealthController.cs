
using Microsoft.AspNetCore.Mvc;

namespace MediSyncApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                status = "Healthy",
                message = "MediSync API is working!"
            });
        }
    }
}
