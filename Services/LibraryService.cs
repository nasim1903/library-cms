using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library_cms.Dtos;

namespace library_cms.Services
{
    
    public class LibraryService : iLibraryService
    {
        private static List<Library> Library = new List<Library> {
            new Library(),
            new Library{Title = "Beloved", Author = "Master"}
        };

        public List<GetLibraryDto> getBooks()
        {
            return Library;
        }

        public GetLibraryDto getOne(int id)
        {
            return Library.FirstOrDefault(c => c.id == id);
   
        }
    }
}