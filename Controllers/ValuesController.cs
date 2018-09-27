using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechnicalRadiation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Get([FromQuery]int pageNumber = 1, [FromQuery]int pageSize = 25)
        {
            
            // 1. sækja fullan lista í service -> repo
                // muna að sækja bara NewsItemDto

            // 2. sorta lista eftir dagsetningu

            // 3. adda öllum referencum

            // 4. setja inn max blaðsíður út frá fyrsta lista

            // 5. returna envelope af 

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
