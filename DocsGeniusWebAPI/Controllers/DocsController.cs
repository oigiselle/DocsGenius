using Microsoft.AspNetCore.Mvc;
using DocsGenius.Models;
using System.Collections.Generic;
using DocsGeniusWebAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DocsGeniusWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocsController : ControllerBase
    {
        private ApiDbContext _dbContext;
        public DocsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/<DocsController>
 /*       [HttpGet]
        public IEnumerable<DocTemplate> Get()
        {
            return _dbContext.;
        } */

        // GET api/<DocsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DocsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DocsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DocsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
