using Microsoft.AspNetCore.Mvc;

namespace TodoListAPI.Controllers
{
    public class TodoListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
