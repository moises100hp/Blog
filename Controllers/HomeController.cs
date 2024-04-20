using Microsoft.AspNetCore.Mvc;


//Health Check
namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("health-check")]
        public ActionResult Get() 
        {
            return Ok();
        }
    }
}
