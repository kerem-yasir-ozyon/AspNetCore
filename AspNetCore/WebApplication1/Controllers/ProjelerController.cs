using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProjelerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
