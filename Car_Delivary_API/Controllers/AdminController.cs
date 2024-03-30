using Microsoft.AspNetCore.Mvc;

namespace Car_Delivary_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
     
        [HttpGet(Name = "FirstAPI")]
        public string Get()
        {
            return "Hello";
        }
    }
}