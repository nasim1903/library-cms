using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library_cms.Dtos;

namespace library_cms.Services
{
    public interface iLibraryService
    {
        Task<ServiceResponse<List<GetLibraryDto>>> getBooks();
        Task<ServiceResponse<List<GetLibraryDto>>> addBooks(AddLibraryDto newBook);
        Task<ServiceResponse<GetLibraryDto>> getOne(int id);
    }
}