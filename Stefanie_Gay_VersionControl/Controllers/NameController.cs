using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stefanie_Gay_VersionControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { Name = "Stefanie Gay" });
        }
    }
}
