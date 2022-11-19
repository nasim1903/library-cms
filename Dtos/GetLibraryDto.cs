using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_cms.Dtos
{
    public class GetLibraryDto
    {
        private static int TotalBooks { get; set; } = 0;
        public int id { get; set; } = TotalBooks;
        public string Title { get; set; } = "Harry Potter";
        public string Author { get; set; } = "JK Rowling";
        public int Pages { get; set; } = 200;

        public GetLibraryDto()
        {
            TotalBooks++;
        }
    }
}