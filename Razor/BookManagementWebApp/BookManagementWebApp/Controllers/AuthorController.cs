using BookManagementWebApp.Dtos;
using BookManagementWebApp.Models;
using BookManagementWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementWebApp.Controllers
{
    public class AuthorController : Controller
    {
        private AuthorService _authorService;
        private BookService _bookService;

        public AuthorController(AuthorService authorService, BookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var data = _authorService.GetAll();
            return View(data);
        }

        public IActionResult Add()
        {
            AuthorDto author = new AuthorDto();
            return View(author);
        }

        [HttpPost]
        public IActionResult Add(Author author)
        {
            _authorService.Add(author);
            return RedirectToAction("Index");
        }
    }
}
