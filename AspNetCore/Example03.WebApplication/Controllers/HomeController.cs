using Example03.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example03.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Kayit()
        {
            var postForm = HttpContext.Request.Form;
            var getForm = HttpContext.Request.Form;

            var postQueryString = HttpContext.Request.Query;
            var getQueryString = HttpContext.Request.Query;
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ContactForm form = new ContactForm();
            return View("IletisimTagHelper",form);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Contact(ContactForm form)
        {
            bool isValid = ModelState.IsValid;
            //string mesaj = $"{ad} {soyad} mesajınız ilgili birime ulaşmıştır. Teşekkür ederiz.";
            //return View("Iletisim",mesaj);
            //return View("IletisimTagHelper", mesaj);

            return RedirectToAction("Index");
        }
    }
}
