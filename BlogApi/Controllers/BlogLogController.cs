using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi.Data;
using BlogApi.Model;
using Microsoft.AspNetCore.Http;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
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
        public void Post([FromBody] BlogForm value)
        {
            try
            {
                this._mongoMaker.saveBlog(value);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
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
