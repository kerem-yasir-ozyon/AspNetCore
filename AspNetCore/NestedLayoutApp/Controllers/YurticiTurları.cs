using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NestedLayoutApp.Controllers
{
    public class YurticiTurları : Controller
    {
        // GET: YurticiTurları
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Akdeniz()
        {
            return View();
        }
        public ActionResult Ege()
        {
            return View();
        }

        // GET: YurticiTurları/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YurticiTurları/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YurticiTurları/Create
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

        // GET: YurticiTurları/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YurticiTurları/Edit/5
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

        // GET: YurticiTurları/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YurticiTurları/Delete/5
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
