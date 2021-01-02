using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Feedbacks.Collector.API.Controllers
{
    /// <summary>
    /// User can add/publish blogs
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [EnableCors("AllowFCAPIOrigin")]
    public class BlogsController : ControllerBase
    {
        // GET: api/<BlogsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BlogsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BlogsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlogsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
