﻿using BookService.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.MVC.Models
{
    public class BookDetailVM
    {
        public BookDetail BookDetail { get; set; }
        public string AuthorJoke { get; set; }
        public string Summary { get; set; }
    }
}
