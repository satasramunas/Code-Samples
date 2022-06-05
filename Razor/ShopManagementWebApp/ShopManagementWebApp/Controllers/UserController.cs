using Microsoft.AspNetCore.Mvc;
using ShopManagementWebApp.Dtos;
using ShopManagementWebApp.Models;
using ShopManagementWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            List<UserDto> users = _userService.GetAll();
            return View(users);     // perduoti users, nes kitaip bus null
        }

        [HttpGet]
        public IActionResult Add()
        {
            var user = new User();
            return View(user);
        }

        [HttpPost]

        // this isn't safe, we should use a Dto. Exposing out user model. And not to give out too much info. 
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return RedirectToAction("Index");
        }
    }
}
