﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BuildWebAPPFromConsole.Controllers
{
    public class HomeController : Controller// For MVC inherit by Controller for Web API Controller hinherit by BaseController class
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
