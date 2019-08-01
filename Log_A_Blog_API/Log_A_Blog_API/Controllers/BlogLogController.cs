using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Log_A_Blog_API.Data;
using Log_A_Blog_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Log_A_Blog_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogLogController : ControllerBase
    {
        IMongoMaker _mongoMaker;

        public BlogLogController(IMongoMaker mongoMaker)
        {
            _mongoMaker = mongoMaker;
        }

        // POST: api/BlogLog
        [HttpPost]
        public void Post([FromBody] BlogFormModel value)
        {
            this._mongoMaker.saveBlog(value);
        }

        // GET: api/BlogLog
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BlogLog/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }


        // PUT: api/BlogLog/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
