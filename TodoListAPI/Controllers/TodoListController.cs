using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllLists()
        {
            return Ok("Success");
        }
    }
}
