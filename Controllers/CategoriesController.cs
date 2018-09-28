using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Service.Implementations;
using TechnicalRadiation.Models.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace TechnicalRadiation.Controllers
{
    public class CategoriesController : ControllerBase
    {
        ICategoriesService _categoryService = new CategoriesService();

        // GET api/categories
        [HttpGet("/api/categories")]
        public IActionResult getAllCategores()
        {
            List<CategoryDto> returnList = new List<CategoryDto>();
            // 1. sækja fullan lista í service -> repo
            List<CategoryDto> categories = _categoryService.getAllCategories();

            // 3. adda öllum referencum 
            foreach (CategoryDto item in categories) {
                returnList.Add(referenceItem(item));
            }
            
            // 5. returna envelope af NewsItemDto
            return Ok(returnList);
        }


        // GET api/2
        [HttpGet("/api/categories/{categoryId}")]
        public ActionResult<string> getNewsItemById(int categoryId)
        {
            CategoryDto category = _categoryService.GetCategoryById(categoryId);

            // adding get single reference
            //category.addReference("self", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            //category.addReference("edit", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            //category.addReference("delete", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            category.addReference("self", "api/categories/" + category.Id);

            return Ok(category);
        }


        /* 

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



        private CategoryDto referenceItem(CategoryDto value) {
            JObject tmpObj = new JObject();
            tmpObj.TryAdd("href", "api/" + value.Id);
            value.addReference("self", tmpObj);
            value.addReference("edit", tmpObj);
            value.addReference("delete", tmpObj);
            return value;
        }

        private CategoryDetailDto referenceItem(CategoryDetailDto value) {
            JObject tmpObj = new JObject();
            tmpObj.TryAdd("href", "api/categories/" + value.Id);
            value.addReference("self", tmpObj);
            value.addReference("edit", tmpObj);
            value.addReference("delete", tmpObj);
            return value;
        }

         
    }
}