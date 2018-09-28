using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Service.Implementations;
using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.Attributes;
using TechnicalRadiation.Models.InputModels;

using Newtonsoft.Json.Linq;
using System.Dynamic;
using TechnicalRadiation.Models.Exceptions;

namespace TechnicalRadiation.Controllers
{
    public class NewsItemController : ControllerBase
    {
        NewsItemService _newsItemService = new NewsItemServiceImpl();
        IRelationService _relationService = new RelationService();

        // GET api/values
        [HttpGet("/api")]
        public IActionResult getAllNewsItems([FromQuery]int pageNumber = 1, [FromQuery]int pageSize = 25)
        {

            
            // 1. sækja fullan lista í service -> repo
                // muna að sækja bara NewsItemDto
            var fullListItems = _newsItemService.getLightweight();
            List<NewsItemDto> returnList = new List<NewsItemDto>();

            var listItems = fullListItems
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            JObject tmpObj = new JObject();
            

            // 3. adda öllum referencum
            foreach (NewsItemDto item in listItems) {
                returnList.Add(referenceLightItem(item));
            }

            // 4. setja inn max blaðsíður út frá fyrsta lista
            var maxPage = (int) Math.Ceiling(fullListItems.Count() / (decimal) pageSize);

            // 5. returna envelope af NewsItemDto
            return Ok(new Envelope<NewsItemDto>(returnList, pageSize, pageNumber, maxPage));
        }

        // GET api/5
        [HttpGet("/api/{id}")]
        public ActionResult<string> getNewsItemById(int id)
        {
            NewsItemDetailDto item = _newsItemService.getNewsItemById(id);
            if(item == null) {
                throw new ResourceNotFoundException();
            }

            return Ok(referenceItem(item));
        }



        // POST api/
        [HttpPost("/api")]
        public ActionResult Post([FromBody] NewsItemInputModel inputModel)
        {
            if (!ModelState.IsValid) {
                
            }
            int modelId = _newsItemService.createNewsItem(inputModel);

            return CreatedAtRoute("getNewsItemById", new { id = modelId }, null);
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

        private NewsItemDto referenceLightItem(NewsItemDto item) {
            JObject tmpObj = new JObject();

            // get all news items authors
            List<NewsAuthorRelation> authourRelList = 
                _relationService.getAutherNewsRelationByNewsId(item.Id);
                
            // get all news items categories
            List<NewsCategoryRelation> categoryRelList =
                _relationService.getNewsCateoryRelationByNewsId(item.Id);

            tmpObj.TryAdd("href", "api/" + item.Id);
            item.addReference("self", tmpObj);
            item.addReference("edit", tmpObj);
            item.addReference("delete", tmpObj);
                
            List<JObject> aObjList = new List<JObject>();
                
            foreach (NewsAuthorRelation aItem in authourRelList) {
                JObject authorObject = new JObject();
                authorObject.TryAdd("href", "api/authors/" + aItem.authorId);
                aObjList.Add(authorObject);
            }

            item.addReference("authors", aObjList);

            List<JObject> cObjList = new List<JObject>();
            foreach (NewsCategoryRelation cItem in categoryRelList) {
                JObject catObject = new JObject();
                catObject.TryAdd("href", "api/categories/" + cItem.categoryId);
                cObjList.Add(catObject);
            }

            item.addReference("categories", cObjList);

            return item;
        }

        private NewsItemDetailDto referenceItem(NewsItemDetailDto item) {
            JObject tmpObj = new JObject();

            // get all news items authors
            List<NewsAuthorRelation> authourRelList = 
                _relationService.getAutherNewsRelationByNewsId(item.Id);
                
            // get all news items categories
            List<NewsCategoryRelation> categoryRelList =
                _relationService.getNewsCateoryRelationByNewsId(item.Id);

            tmpObj.TryAdd("href", "api/" + item.Id);
            item.addReference("self", tmpObj);
            item.addReference("edit", tmpObj);
            item.addReference("delete", tmpObj);
                
            List<JObject> aObjList = new List<JObject>();
                
            foreach (NewsAuthorRelation aItem in authourRelList) {
                JObject authorObject = new JObject();
                authorObject.TryAdd("href", "api/authors/" + aItem.authorId);
                aObjList.Add(authorObject);
            }

            item.addReference("authors", aObjList);

            List<JObject> cObjList = new List<JObject>();
            foreach (NewsCategoryRelation cItem in categoryRelList) {
                JObject catObject = new JObject();
                catObject.TryAdd("href", "api/categories/" + cItem.categoryId);
                cObjList.Add(catObject);
            }

            item.addReference("categories", cObjList);

            return item;
        }
    }
}