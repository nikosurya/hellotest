using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using httpclient;


namespace hello.Controllers
{
    [Route("api/niko/[controller]")]
    public class HelloController : Controller
    {
       

        // GET api/values
        [HttpGet]
        public async Task< IEnumerable<string>> Get()
        {
          
          return new string[] { "Hello World"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }        
    }
}
