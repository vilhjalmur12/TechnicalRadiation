using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Service;
using TechnicalRadiation.Models;

namespace TechnicalRadiation.Controllers
{
    //[Route("/api")]
    //[ApiController]
    public class ValuesController : ControllerBase
    {
        /*
        NewsItemService _newsItemService = new NewsItemServiceImpl();

        // GET api/values
        [HttpGet("/api")]
        public IActionResult getAllNewsItems([FromQuery]int pageNumber = 1, [FromQuery]int pageSize = 25)
        {
            
            // 1. sækja fullan lista í service -> repo
                // muna að sækja bara NewsItemDto
            var fullListItems = _newsItemService.getLightweight();

            var listItems = fullListItems
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // 3. adda öllum referencum
            foreach (NewsItemDto item in listItems) {
                item.addReference("self", "new link");
            }

            // 4. setja inn max blaðsíður út frá fyrsta lista
            var maxPage = (int) Math.Ceiling(fullListItems.Count() / (decimal) pageSize);

            // 5. returna envelope af NewsItemDto
            return Ok(new Envelope<NewsItemDto>(listItems, pageSize, pageNumber, maxPage));
        }

        

        // GET api/5
        [HttpGet("/api/{id}")]
        public ActionResult<string> getNewsItemById(int id)
        {
            NewsItemDetailDto item = _newsItemService.getNewsItemById(id);


            item.addReference("self", "tmp self");
            return Ok(item);
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
         */
    }
}
