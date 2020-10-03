using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildWebAPPFromConsole.Model;
using Microsoft.AspNetCore.Mvc;

namespace BuildWebAPPFromConsole.Controllers
{
    public class AccountController : Controller
    {
        [Route("signup")]
        public IActionResult Signup()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public IActionResult Signup(SignUpUserModel userModel)
        {
            if (ModelState.IsValid)
            {
                // write your code

                ModelState.Clear();
            }
            return View();
        }
    }
}
