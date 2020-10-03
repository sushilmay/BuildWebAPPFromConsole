using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildWebAPPFromConsole.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace BuildWebAPPFromConsole.Controllers
{
    public class HomeController : Controller// For MVC inherit by Controller for Web API Controller hinherit by BaseController class
    {
        private readonly IConfiguration _configuration;

        //Work as AddSingleton
        public readonly NewBookAlertConfig _newBookAlertConfig;

        //Work as AddScope 
        public readonly NewBookAlertConfig _newBookAlertConfigSnapshot;

        public HomeController(IConfiguration configuration, IOptions<NewBookAlertConfig> configurationNewBookAlert,
            IOptionsSnapshot<NewBookAlertConfig> configurationNewBookAlertSnapshot
            )
        {
            _configuration = configuration;
            _newBookAlertConfig = configurationNewBookAlert.Value;
            _newBookAlertConfigSnapshot = configurationNewBookAlertSnapshot.Value;
        }


        public ViewResult Index()
        {
            var newBookAlert = new NewBookAlertConfig();
            _configuration.Bind("NewBookAlert", newBookAlert);
            //var sectionNewBookAlert = _configuration.GetSection("NewBookAlert");
            //bool result = sectionNewBookAlert.GetValue<bool>("DisplayNewBookAlert");
            //string bookName = sectionNewBookAlert.GetValue<string>("BookName");

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
