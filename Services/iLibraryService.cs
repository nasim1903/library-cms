using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library_cms.Dtos;

namespace library_cms.Services
{
    public interface iLibraryService
    {
        ServiceResponse<List<GetLibraryDto>> getBooks();
        ServiceResponse<GetLibraryDto> getOne(int id);
    }
}