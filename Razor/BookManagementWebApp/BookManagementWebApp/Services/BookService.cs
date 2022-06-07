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

        //uzkraunam entity ir entity permappinam i Dto
        public List<BookDto> GetAll()
        {
            var entities = _dataContext.Books.ToList();
            return entities.Select(e => new BookDto
            {
                Id = e.Id,
                Name = e.Name
            }).ToList();
        }

        //irgi, turim Dto ir permappinma i entity
        //tada prisidedam, issaugom
        //priima Dto ir tada sukuriam entity viduje
        //jeigu grazintumem kazka is cia, reiketu grazinti Dto
        public void Add(BookDto bookDto)
        {
            Book entity = new Book
            {
                Name = bookDto.Name,
                AuthorId = bookDto.AuthorId
            };
            _dataContext.Books.Add(entity);
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
