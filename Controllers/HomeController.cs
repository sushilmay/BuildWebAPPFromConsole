using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BuildWebAPPFromConsole.Controllers
{
    public class HomeController : Controller// For MVC inherit by Controller for Web API Controller hinherit by BaseController class
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ViewResult Index()
        {
            var sectionNewBookAlert = _configuration.GetSection("NewBookAlert");
            bool result = sectionNewBookAlert.GetValue<bool>("DisplayNewBookAlert");
            string bookName = sectionNewBookAlert.GetValue<string>("BookName");

            return View();
        }
        public ViewResult Aboutus()
        {
            return View();
        }
        public ViewResult Contactus()
        {
            return View();
        }
    }
}
