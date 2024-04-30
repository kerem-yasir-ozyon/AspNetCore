using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NestedLayoutApp.Controllers
{
    public class YurtdisiTurları : Controller
    {
        // GET: YurtdisiTurları
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Avrupa()
        {
            return View();
        }
        public ActionResult Asya()
        {
            return View();
        }

        // GET: YurtdisiTurları/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YurtdisiTurları/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YurtdisiTurları/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: YurtdisiTurları/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YurtdisiTurları/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: YurtdisiTurları/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YurtdisiTurları/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
