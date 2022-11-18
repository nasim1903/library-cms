using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace library_cms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private static List<Library> Library = new List<Library> {
            new Library(),
        };
        [HttpGet("get")]
        public ActionResult<Library> GetResult()
        {
            return Ok(Library);
        }
    }
}