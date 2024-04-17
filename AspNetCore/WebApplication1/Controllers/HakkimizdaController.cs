using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HakkimizdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
