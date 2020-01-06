using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserSignup.Models;
using UserSignup.ViewModels;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            AddUserViewModel emptyuser = new AddUserViewModel()
            {
                Username = "No User",
                Email = null,
                Password = "password",
                Verify = "password"
            };
            return View(emptyuser);
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/User/Add")]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {

            if (ModelState.IsValid)
            {
                return View("Index", addUserViewModel);
            }

            //// not used for strings -- user.Password == verify
            //if (user != null && user.Password.Equals(verify))
            //{
            //    return Redirect($"Index?username={user.Username}");
            //}

            //if (user != null)
            //{
            //    ViewBag.username = user.Username;
            //    ViewBag.email = user.Email;
            //}

            return View(addUserViewModel);
        }
    }
}
