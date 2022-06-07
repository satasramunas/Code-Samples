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
        private AuthorService _authorService;

        public BookController(BookService bookService, AuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
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
            book.Author = _authorService.GetAll();
            return View(book);
        }

        [HttpPost]
        public IActionResult Add(BookDto bookDto)
        {
            _bookService.Add(bookDto);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            _bookService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
