using Microsoft.AspNetCore.Mvc;
using ShopManagementWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<User>();
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            return RedirectToAction("Index");
        }
    }
}
