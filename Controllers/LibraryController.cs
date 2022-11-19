using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library_cms.Dtos;
using library_cms.Services;
using Microsoft.AspNetCore.Mvc;

namespace library_cms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly iLibraryService _libraryService;
        public LibraryController(iLibraryService libraryService)
        {
            _libraryService = libraryService;
            
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<GetLibraryDto>>> GetResult()
        {
            return Ok (await _libraryService.getBooks());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetLibraryDto>>> getSingle(int id)
        {
            return Ok(await _libraryService.getOne(id));
        }
        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<GetLibraryDto>>> AddBook(AddLibraryDto newBook)
        {
            return Ok(await _libraryService.addBooks(newBook));
        }
        [HttpPut()]
        public async Task<ActionResult<ServiceResponse<GetLibraryDto>>> UpdateBook(UpdateLibraryDto updateBook, int id)
        {
            return Ok(await _libraryService.updateBook(updateBook, id));
        }
    }
}