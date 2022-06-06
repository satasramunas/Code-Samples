using BookManagementWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementWebApp.Controllers
{
    public class AuthorController
    {
        private AuthorService _authorService;
        private BookService _bookService;

        public AuthorController(AuthorService authorService, BookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }
    }
}
