﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ReemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult hello()
        {
            return Content("hello from sravia");
        }
    }
}
