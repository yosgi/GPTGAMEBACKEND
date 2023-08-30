using Microsoft.AspNetCore.Mvc;

namespace MyBackendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello from .NET Backend!";
        }
    }
}
