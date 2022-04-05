using ASP_Task2.Entities;
using ASP_Task2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webhost;

        public HomeController(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }

        FakeRP.UserRP userRP = new FakeRP.UserRP();

        public IActionResult Index()
        {
            return View(userRP.GetAllUsers());
        }

        [HttpGet]
        public IActionResult Register()
        {
            UserVM userVM = new UserVM
            {
                User = new User()
            };

            return View(userVM);
        }
        [HttpPost]
        public IActionResult Register(UserVM model)
        {
            FakeRP.UserRP.Users.Add(model.User);

            return RedirectToAction("Index");
        }
    }
}
