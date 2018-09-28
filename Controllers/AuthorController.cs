using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Service.Implementations;
using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Models.Exceptions;
using Newtonsoft.Json.Linq;

using Newtonsoft.Json;
using System.Dynamic;
using TechnicalRadiation.Models.Attributes;

namespace TechnicalRadiation.Controllers
{
    public class AuthorController : ControllerBase
    {
        IAuthorService _authorService = new AuthorService();
        IRelationService _relationService = new RelationService();
        NewsItemService _newsService = new NewsItemServiceImpl();




        // GET api/authors
        [HttpGet("/api/authors")]
        public IActionResult getAllAuthors()
        {
            List<AuthorDto> returnValue = new List<AuthorDto>();
            
            // 1. sækja fullan lista í service -> repo
            List<AuthorDto> authors = _authorService.getAllAuthors();

            // 3. adda öllum referencum 
            foreach (AuthorDto item in authors) {
                returnValue.Add(referenceItem(item));
            }
            
            // 5. returna envelope af NewsItemDto
            return Ok(authors);
        }



        // GET api/authors/2
        [HttpGet("/api/authors/{authorId}")]
        public ActionResult<string> getAuthorById(int authorId)
        {
            AuthorDetailDto author = _authorService.getAuthorById(authorId);
            return Ok(referenceItem(author));
        }

        // POST api/author
        [BasicAuthenticationAtrribute]
        [HttpPost("/api/authors")]
        public ActionResult<string> createAuthor([FromBody] AuthorInputModel inputModel)
        {
            if (!ModelState.IsValid) {
                throw new ModelFormatException();
            }
            int modelId = _authorService.createAuthor(inputModel);             
            return getAuthorById(modelId);
        }

        // PUT api/5
        [HttpPut("/api/authors/{authorId}")]
        public void updateAuthor(int authorId, [FromBody] AuthorInputModel inputModel)
        {
            if(!ModelState.IsValid) { throw new ModelFormatException(); }
            _authorService.updateAuthorById(inputModel, authorId);
        }

        // DELETE api/values/5
        [HttpDelete("/api/authors/{authorId}")]
        public void Delete(int authorId)
        {
            _authorService.deleteAuthorById(authorId);
        }



        // GET api/authors/2/newsItems
        [HttpGet("/api/authors/{authorId}/newsItems")]
        public ActionResult<string> getAuthorNews(int authorId)
        {
            List<NewsItemDetailDto> returnValue = new List<NewsItemDetailDto>();

            // Find authors news
            List<NewsItemDetailDto> newsList = _relationService.getRelationsByAuthorId(authorId)
                .Select( item => _newsService.getNewsItemById(item.newsId)).ToList();

            foreach(NewsItemDetailDto item in newsList) {
                returnValue.Add(referenceItem(item));
            }
            
            return Ok(returnValue);
        }





        private AuthorDto referenceItem(AuthorDto item) {
            JObject tmpObj = new JObject();

            // get all news items authors
            List<NewsAuthorRelation> authourRelList = 
                _relationService.getRelationsByAuthorId(item.Id);

            tmpObj.TryAdd("href", "api/authors/" + item.Id);
            item.addReference("self", tmpObj);
            item.addReference("edit", tmpObj);
            item.addReference("delete", tmpObj);
            tmpObj.TryAdd("href", "api/authors/" + item.Id + "/newsItems");
            item.addReference("newsItems", tmpObj);

            List<JObject> objList = new List<JObject>();
            foreach (NewsAuthorRelation relation in authourRelList) {
                JObject relObj = new JObject();
                relObj.TryAdd("href", "api/" + relation.newsId);
                objList.Add(relObj);
            }

            item.addReference("newsItemsDetailed", objList);
            
            return item;
        }




        private AuthorDetailDto referenceItem(AuthorDetailDto item) {
            JObject tmpObj = new JObject();

            // get all news items authors
            List<NewsAuthorRelation> authourRelList = 
                _relationService.getRelationsByAuthorId(item.Id);

            tmpObj.TryAdd("href", "api/authors/" + item.Id);
            item.addReference("self", tmpObj);
            item.addReference("edit", tmpObj);
            item.addReference("delete", tmpObj);
            tmpObj.TryAdd("href", "api/authors/" + item.Id + "/newsItems");
            item.addReference("newsItems", tmpObj);

            List<JObject> objList = new List<JObject>();
            foreach (NewsAuthorRelation relation in authourRelList) {
                JObject relObj = new JObject();
                relObj.TryAdd("href", "api/" + relation.newsId);
                objList.Add(relObj);
            }

            item.addReference("newsItemsDetailed", objList);
            
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