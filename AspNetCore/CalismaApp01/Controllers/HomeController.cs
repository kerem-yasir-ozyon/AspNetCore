using CalismaApp01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalismaApp01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public ViewResult Calisma1()
        {
            return View();
        }
        public PartialViewResult Calisma2()
        {
            return new PartialViewResult();
        }
        //public JsonResult Calisma3()
        //{
        //    //Araba sýnýfýndan oluþan bir nesneyi JSON'a çevirip döndüreceðiz 
        //    Araba araba = new Araba()  // 
        //    {
        //        Model = 2022,
        //        Renk = "Mavi"
        //    };
        //    return new JsonResult(araba);
        //}
        public EmptyResult Calisma4()
        {
            return new EmptyResult(); //viewi olmamasýna ragmen calsýýyor
        }






        public RedirectToActionResult Calisma5()
        {
            return RedirectToAction("Index"); // viewi indexe gidiyor
        }

        public StatusCodeResult Calisma6()
        {
            return new StatusCodeResult(404);  //404 not found // viewi olsun olmasýn 404 hatasý yolluyor
        }
        public ContentResult Calisma7()
        {
            return Content("Merhaba, bugün 4.1.2023 çarþamba");
        }

        public NotFoundResult Calisma8()
        {
            return new NotFoundResult(); // notfound viewi olsada bulunmuyor
        }


        //public NotFoundResult Calisma9()
        //{
        //    return View(); // 
        //}
        //public PartialViewResult Calisma10()
        //{
        //    return  View(); // PartialViewResult adýnda bir view dondurmesý gerekýr
        //}


        //public IActionResult Calisma11()
        //{
        //    //Araba sýnýfýndan oluþan bir nesneyi JSON'a çevirip döndüreceðiz 
        //    Araba araba = new Araba()
        //    {
        //        Model = 2022,
        //        Renk = "Mavi"
        //    };
        //    return new JsonResult(araba);
        //}
        //public JsonResult Calisma12()
        //{
        //    return new EmptyResult();
        //}


        //public StatusCodeResult Calisma13()
        //{
        //    return RedirectToAction("Index");
        //}

        //public JsonResult Calisma14()
        //{
        //    return new StatusCodeResult(404);  //404 not found 
        //}
        //public JsonResult Calisma15()
        //{
        //    return Content("Merhaba, bugün 4.1.2023 çarþamba");
        //}

        //public IActionResult Calisma16()
        //{
        //    return new NotFoundResult();
        //} 
    }
}
