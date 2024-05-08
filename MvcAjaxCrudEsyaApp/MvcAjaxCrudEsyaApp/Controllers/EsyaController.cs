using Microsoft.AspNetCore.Mvc;
using MvcAjaxCrudEsyaApp.Data;
using MvcAjaxCrudEsyaApp.Data.Entity;

namespace MvcAjaxCrudEsyaApp.Controllers
{
    public class EsyaController : Controller
    {
        private EsyaAppDbContext _db;

        public EsyaController(EsyaAppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Listele()
        {
            
            return Json(_db.Esyalar.ToList());
        }
        
        [HttpPost]
        public IActionResult Ekle(Esya esya)
        {
            _db.Esyalar.Add(esya);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
