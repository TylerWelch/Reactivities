using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]//add this to improve the developer experience for building apis
    [Route("api/[controller]")] //http://localhost:5000/weatherforecast
    public class BaseApiController : ControllerBase
    {
        
    }
}