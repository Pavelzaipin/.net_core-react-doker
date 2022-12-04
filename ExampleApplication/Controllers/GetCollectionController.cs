using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApplication.Controllers
{
    [Route("api/collection")]
    [ApiController]
    public class GetCollectionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCollection()
        {
            var collection = new[]
            {
                new {Name = "One"},
                new {Name = "Two"},
                new {Name = "Three" }
            };

            return Ok(collection);
        }
    }
}
