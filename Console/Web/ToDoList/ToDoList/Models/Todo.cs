﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Todo
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public DateTime CreateUtc { get; set; }
    }
}
