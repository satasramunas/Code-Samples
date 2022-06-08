using BookManagementWebApp.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementWebApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        //[NotMapped]
        public List<Book> Books { get; set; }
    }
}
