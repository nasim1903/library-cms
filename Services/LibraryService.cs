using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using library_cms.Dtos;

namespace library_cms.Services
{

    public class LibraryService : iLibraryService
    {
        private readonly IMapper _mapper;
        public LibraryService(IMapper mapper)
        {
            _mapper = mapper;
        }
        private static List<Library> Library = new List<Library> {
            new Library(),
            new Library{Title = "Beloved", Author = "Master"}
        };

        public async Task<ServiceResponse<List<GetLibraryDto>>> getBooks()
        {
            return new ServiceResponse<List<GetLibraryDto>>()
            {
                Data = Library.Select(c => _mapper.Map<GetLibraryDto>(c)).ToList()
            };
        }
        public async Task<ServiceResponse<GetLibraryDto>> getOne(int id)
        {
            var response = new ServiceResponse<GetLibraryDto>();
            var character = Library.FirstOrDefault(c => c.id == id);
            response.Data = _mapper.Map<GetLibraryDto>(character);
            return response;       
        }
    }
}
