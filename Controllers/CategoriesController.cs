using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Service.Implementations;
using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Models.Exceptions;
using TechnicalRadiation.Models.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace TechnicalRadiation.Controllers
{
    public class CategoriesController : ControllerBase
    {
        ICategoriesService _categoryService = new CategoriesService();
        IRelationService _relationService = new RelationService();

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
            
            // 5. returna envelope 
            return Ok(returnList);
        }


        // GET api/2
        [HttpGet("/api/categories/{categoryId}")]
        public ActionResult<string> getCategoryById(int categoryId)
        {
            CategoryDto category = _categoryService.GetCategoryById(categoryId);
            return Ok(referenceItem(category));
        }


        // POST api/values
        [BasicAuthenticationAtrribute]
        [HttpPost("/api/categories")]
        public ActionResult<string> createCategory([FromBody] CategoryInputModel inputModel)
        {
            if (!ModelState.IsValid) {
                throw new ModelFormatException();
            }
            return getCategoryById(_categoryService.createCategory(inputModel));
        }

        // PUT api/values/5
        [BasicAuthenticationAtrribute]
        [HttpPut("/api/categories/{categoryId}")]
        public void updateCategoryById(int categoryId, [FromBody] CategoryInputModel inputModel)
        {
            if (!ModelState.IsValid) {
                throw new ModelFormatException();
            }
            _categoryService.updateCategoryById(categoryId, inputModel);
        }

        // DELETE api/values/5
        [BasicAuthenticationAtrribute]
        [HttpDelete("/api/categories/{categoryId}")]
        public void deleteCategoryById(int categoryId)
        {
            _categoryService.deleteCategoryById(categoryId);
        }


        // Creates relation between NewsItem and a Category
        // POST api/categories/2/newsItem/20
        [BasicAuthenticationAtrribute]
        [HttpPost("/api/categories/{categoryId}/newsItems/{newsItemId}")]
        public ActionResult<string> createCategoryNewsRelation(int categoryId, int newsItemId)
        {
            _relationService.setNewsCategoryRelations(newsItemId, categoryId);
            return Ok();
        }

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