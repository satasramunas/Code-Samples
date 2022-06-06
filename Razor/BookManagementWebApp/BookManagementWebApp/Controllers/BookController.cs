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
    public class BookController : Controller
    {
        private BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            List<BookDto> _books = _bookService.GetAll();
            return View(_books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            BookDto book = new BookDto();
            //book.Authors = _bookService.GetAll(); 
            return View(book);
        }

        [HttpPost]
        public IActionResult Add(BookDto book)
        {
            _bookService.Add(book);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            _bookService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
