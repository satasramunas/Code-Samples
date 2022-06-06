﻿using BookManagementWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementWebApp.Dtos
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BookDto> Books { get; set; }
    }
}
