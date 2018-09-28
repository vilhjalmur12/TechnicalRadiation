using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Service.Implementations;
using TechnicalRadiation.Models.DTO;
using Newtonsoft.Json;
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
            
            // 1. sækja fullan lista í service -> repo
            List<CategoryDto> categories = _categoryService.getAllCategories();

            // 3. adda öllum referencum 
            foreach (CategoryDto item in categories) {
                item.addReference("self", "new link");
            }
            
            // 5. returna envelope af NewsItemDto
            return Ok(categories);
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

        private void referenceNewsItem(ref NewsItemDto value) {
            value.addReference("self", new ExpandoObject().TryAdd("href", "api/" + value.Id));
        }

         */
    }
}