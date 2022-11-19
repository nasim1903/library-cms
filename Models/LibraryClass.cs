using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_cms.Models
{
    public class Library
    {
        private static int TotalBooks { get; set; } = 0;
        public int id { get; set; } = TotalBooks;
        public string Title { get; set; } = "Harry Potter";
        public string Author { get; set; } = "JK Rowling";
        public int Pages { get; set; } = 200;

        public Library()
        {
            TotalBooks++;
        } 
    }
}