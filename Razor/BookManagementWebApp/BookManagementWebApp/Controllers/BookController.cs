using BookManagementWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementWebApp.Controllers
{
    public class BookController
    {
        private BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

    }
}
