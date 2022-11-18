using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_cms.Models
{
    public class Library
    {
        public string BookTitle { get; set; } = "Harry Potter";
        public string Author { get; set; } = "JK Rowling";
        public int Pages { get; set; } = 200;

        public Library()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Title: "+BookTitle);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Pages: " + Pages);

        } 
    }
}