using BookManagementWebApp.Data;
using BookManagementWebApp.Dtos;
using BookManagementWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementWebApp.Services
{
    public class AuthorService
    {
        private DataContext _dataContext;

        public AuthorService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<AuthorDto> GetAll()
        {
            var authors = _dataContext.Authors.Include(i => i.Books).ToList();
            return authors.Select(x => new AuthorDto
            {
                Id = x.Id,
                Name = x.Name,
                Books = x.Books.Select(y => new BookDto
                {
                    Id = y.Id,
                    Name = y.Name
                }).ToList()
            }).ToList();
        }

        public void Add(Author author)
        {
            _dataContext.Authors.Add(author);
            _dataContext.SaveChanges();
        }

        public void Delete(string name)
        {
            var author = _dataContext.Authors.FirstOrDefault(t => t.Name == name);
            _dataContext.Authors.Remove(author);
            _dataContext.SaveChanges();
        }
    }
}
