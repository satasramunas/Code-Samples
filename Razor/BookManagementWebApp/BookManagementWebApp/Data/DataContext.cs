using BookManagementWebApp.Dtos;
using BookManagementWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementWebApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BookDto> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
