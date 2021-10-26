using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ProAgile.WebAPI.Model;

namespace ProAgile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Event>> Get()
        {
            return new Event[] {
                new Event() {
                    id = 1,
                    place = "Toronto Island",
                    date = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
                    theme = "Angular and .NET Core",
                    peopleAmount = 1,
                    lot = "1o lot"
                },
                new Event() {
                    id = 2,
                    place = "Toronto Island",
                    date = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
                    theme = "React and Java",
                    peopleAmount = 1,
                    lot = "1o lot"
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            return new Event[] {
                new Event() {
                    id = 1,
                    place = "Toronto Island",
                    date = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
                    theme = "Angular and .NET Core",
                    peopleAmount = 1,
                    lot = "1o lot"
                },
                new Event() {
                    id = 2,
                    place = "Toronto Island",
                    date = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
                    theme = "React and Java",
                    peopleAmount = 1,
                    lot = "1o lot"
                }
            }.FirstOrDefault(x => x.id == id);
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
