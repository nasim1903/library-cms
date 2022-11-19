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
            var book = Library.FirstOrDefault(c => c.id == id);
            response.Data = _mapper.Map<GetLibraryDto>(book);
            return response;
        }

        public async Task<ServiceResponse<List<GetLibraryDto>>> addBooks(AddLibraryDto newBook)
        {
            var response = new ServiceResponse<List<GetLibraryDto>>();
            var book = _mapper.Map<Library>(newBook);
            Library.Add(book);
            response.Data = Library.Select(c => _mapper.Map<GetLibraryDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetLibraryDto>> updateBook(UpdateLibraryDto updateBook, int id)
        {
            var serviceResponse = new ServiceResponse<GetLibraryDto>();
            var book = Library.FirstOrDefault(c => c.id == id);

            try
            {
                _mapper.Map(updateBook, book);

                serviceResponse.Data = _mapper.Map<GetLibraryDto>(book);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetLibraryDto>>> deleteBook(int id)
        {
            var response = new ServiceResponse<List<GetLibraryDto>>();
            var book = Library.FirstOrDefault(c => c.id == id);
            Library.Remove(book);

            response.Data = Library.Select(c => _mapper.Map<GetLibraryDto>(c)).ToList();
            return response;
        }
    }
}
