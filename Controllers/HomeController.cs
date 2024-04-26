using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;


//Health Check
namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("health-check")]
        //[ApiKey]
        public ActionResult Get(
            [FromServices]IConfiguration config) 
        {
            var env = config.GetValue<string>("Env");
            return Ok(new
            {
                enviroment = env,
            });
        }
    }
}
