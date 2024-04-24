using Microsoft.AspNetCore.Mvc;

namespace Example05.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Anasayfa";
            return View();
        }

        public IActionResult NewAction()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
