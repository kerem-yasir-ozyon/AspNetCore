using Example05.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example05.WebApplication.Controllers
{
    public class Students : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            var request = HttpContext.Request;
            //var form = request.Form;
            var query = request.Query;
            var queryStr = request.QueryString;
            return View();
        }

        [HttpPost]
        //public IActionResult Add(IFormCollection Form)
        //public IActionResult Add(string Ad, string Soyad, string Eposta, string DTarihi)
        //public IActionResult Add([Bind("Ad","Soyad","DTarihi")]Student student)
        public IActionResult Add( Student student)
        {
            //var request = HttpContext.Request;
            //var form = request.Form;
            return View();
        }
    }
}
