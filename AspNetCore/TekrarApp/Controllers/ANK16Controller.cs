using Microsoft.AspNetCore.Mvc;

namespace TekrarApp.Controllers
{
    public class ANK16Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sinif()
        {
            return View();
        }
        public IActionResult Rastgele()
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 100);
            ViewBag.veri = rastgeleSayi;
            //ViewBag.rastgeleSayi = random.Next(1, 100);
            return View();
        }
        public IActionResult Sayilar()
        {
            List<int> sayilar = new List<int>();
            for (int i = 1; i < 20; i++)
            {
                sayilar.Add(i);
            }
            ViewBag.say = sayilar;
            return View();
        }
        public IActionResult Kisi(string ad,string soyad,int yas)
        {
            if (yas != null && ad != null && soyad != null)
            
                ViewBag.ad = ad;
                ViewBag.soyad = soyad;
                ViewBag.yas = yas;
            
                
            return View();
        }
    }
}
