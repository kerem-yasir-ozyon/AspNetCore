﻿using Microsoft.AspNetCore.Mvc;

namespace Example05.WebApplication.Controllers
{
    public class Teachers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
