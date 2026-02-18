using Microsoft.AspNetCore.Mvc;

namespace Day5_QuerySelectors.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Highlight()
        {
            return View();
        }
    }
}
