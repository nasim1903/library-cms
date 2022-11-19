using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_cms.Dtos
{
    public class UpdateLibraryDto
    {
        public string Title { get; set; } = "Harry Potter";
        public string Author { get; set; } = "JK Rowling";
        public int Pages { get; set; } = 200;

    }
}