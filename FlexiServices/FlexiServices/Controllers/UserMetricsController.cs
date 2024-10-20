using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlexiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMetricsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "123";
        }
    }
}
