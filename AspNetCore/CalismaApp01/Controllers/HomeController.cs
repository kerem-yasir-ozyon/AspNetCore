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
        //    //Araba s�n�f�ndan olu�an bir nesneyi JSON'a �evirip d�nd�rece�iz 
        //    Araba araba = new Araba()  // 
        //    {
        //        Model = 2022,
        //        Renk = "Mavi"
        //    };
        //    return new JsonResult(araba);
        //}
        public EmptyResult Calisma4()
        {
            return new EmptyResult(); //viewi olmamas�na ragmen cals��yor
        }






        public RedirectToActionResult Calisma5()
        {
            return RedirectToAction("Index"); // viewi indexe gidiyor
        }

        public StatusCodeResult Calisma6()
        {
            return new StatusCodeResult(404);  //404 not found // viewi olsun olmas�n 404 hatas� yolluyor
        }
        public ContentResult Calisma7()
        {
            return Content("Merhaba, bug�n 4.1.2023 �ar�amba");
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
        //    return  View(); // PartialViewResult ad�nda bir view dondurmes� gerek�r
        //}


        //public IActionResult Calisma11()
        //{
        //    //Araba s�n�f�ndan olu�an bir nesneyi JSON'a �evirip d�nd�rece�iz 
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
        //    return Content("Merhaba, bug�n 4.1.2023 �ar�amba");
        //}

        //public IActionResult Calisma16()
        //{
        //    return new NotFoundResult();
        //} 
    }
}
