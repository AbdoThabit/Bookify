﻿using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}