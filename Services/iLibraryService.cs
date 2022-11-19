using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_cms.Services
{
    public interface iLibraryService
    {
        List<Library> getBooks();
        Library getOne(int id);
    }
}