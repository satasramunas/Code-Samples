using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWebApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public decimal Price { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; } = "Admin";
    }
}
