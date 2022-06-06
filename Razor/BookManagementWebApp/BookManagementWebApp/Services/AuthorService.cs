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
    public class AuthorService
    {
        private DataContext _dataContext;

        public AuthorService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<AuthorDto> GetAll()
        {
            var authors = _dataContext.Authors.ToList();
            var dtos = authors.Select(x => new AuthorDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return dtos;
        }

        public void Add(Author author)
        {
            _dataContext.Authors.Add(author);
            _dataContext.SaveChanges();
        }

        public void Delete(string name)
        {
            var item = _dataContext.Authors.FirstOrDefault(t => t.Name == name);
            _dataContext.Authors.Remove(item);
            _dataContext.SaveChanges();
        }
    }
}
