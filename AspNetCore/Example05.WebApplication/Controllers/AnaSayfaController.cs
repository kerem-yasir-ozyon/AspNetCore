using Microsoft.AspNetCore.Mvc;

namespace Example05.WebApplication.Controllers
{
    public class AnaSayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
