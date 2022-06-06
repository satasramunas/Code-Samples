using BookManagementWebApp.Data;
using BookManagementWebApp.Dtos;
using BookManagementWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementWebApp.Services
{
    public class BookService
    {
        private DataContext _dataContext;

        public BookService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<BookDto> GetAll()
        {
            return _dataContext.Books.ToList();
        }

        public void Add(BookDto book)
        {
            _dataContext.Books.Add(book);
            _dataContext.SaveChanges();
        }

        public void Delete(string name)
        {
            var book = _dataContext.Books.FirstOrDefault(t => t.Name == name);
            _dataContext.Books.Remove(book);
            _dataContext.SaveChanges();
        }
    }
}
