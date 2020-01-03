using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(User user)
        {
            ViewBag.user = user;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            ViewBag.user = user;
            if (user.Username == null
                || user.Email == null
                || user.Password == null)
            {
                return View("Add");
            }
            else if (user.Password.Equals(verify))
            {
                ViewBag.verifyError = "Those passwords don't match!";
                return View("Add");
            }
            return View("Index", user);
        }
    }
}
