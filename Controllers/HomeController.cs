using Microsoft.AspNetCore.Mvc;

namespace ERPService.Controllers
{
    [ApiController]
    public class HomeController:ControllerBase
    {
        [Route("/")]
        [HttpGet]
        public IActionResult Get() {
            return Ok("{Ok}");
        }
    }
}
