using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Greetings()
        {
            return "Hi Alex!!!";
        }
    }
}
