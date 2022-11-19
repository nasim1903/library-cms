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
        public ActionResult<GetLibraryDto> GetResult()
        {
            return Ok(_libraryService.getBooks());
        }

        [HttpGet("{id}")]
        public ActionResult<GetLibraryDto> getSingle(int id)
        {
            return Ok(_libraryService.getOne(id));
        }
    }
}