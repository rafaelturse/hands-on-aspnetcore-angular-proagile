using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgile.WebAPI.Data;
using ProAgile.WebAPI.Model;

namespace ProAgile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext Context { get; }
        public ValuesController(DataContext context)
        {
            Context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Event>> Get()
        {
            return Context.Events.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            return Context.Events.ToList().FirstOrDefault(x => x.id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
