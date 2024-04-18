using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            Student student = new Student();

            List<SelectListItem> selectListItems = new List<SelectListItem>();

            selectListItems.Add(new SelectListItem() { Value = "0", Text = Cars.Audi.ToString() });
            selectListItems.Add(new SelectListItem() { Value = "1", Text = Cars.Bmw.ToString() });
            selectListItems.Add(new SelectListItem() { Value = "2", Text = Cars.Tofas.ToString() });


            ViewBag.Cars = selectListItems;

            return View(student);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            //List<SelectListItem> selectListItems = new List<SelectListItem>();

            //selectListItems.Add(new SelectListItem() { Value = "0", Text = Cars.Audi.ToString() });
            //selectListItems.Add(new SelectListItem() { Value = "1", Text = Cars.Bmw.ToString() });
            //selectListItems.Add(new SelectListItem() { Value = "2", Text = Cars.Tofas.ToString() });


            //ViewBag.Cars = selectListItems;

            return View(student);
        }
    }
}
