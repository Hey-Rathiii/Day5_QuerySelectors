using Microsoft.AspNetCore.Mvc;

namespace Day5_QuerySelectors.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Highlight()
        {
            return View();
        }

        public IActionResult Notification()
        {
            return View();
        }

        public IActionResult Prepend()
        {
            return View();
        }

        public IActionResult EntireTheme()
        {
            return View();
        }

        public IActionResult LiveSearch()
        {
            return View();
        }
    }
}
