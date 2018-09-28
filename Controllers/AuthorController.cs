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
    public class AuthorController : ControllerBase
    {
        IAuthorService _authorService = new AuthorService();
        IRelationService _relationService = new RelationService();
        NewsItemService _newsService = new NewsItemServiceImpl();

        // GET api/authors
        [HttpGet("/api/authors")]
        public IActionResult getAllCategores()
        {
            
            // 1. sækja fullan lista í service -> repo
            List<AuthorDto> authors = _authorService.getAllAuthors();

            // 3. adda öllum referencum 
            foreach (AuthorDto item in authors) {
                item.addReference("self", "new link");
                item.addReference("edit", "new link");
                item.addReference("delete", "new link");
                item.addReference("newsItems", "should be object of news");
                item.addReference("newsItemsDetailed", "should be object list of detailed news");
            }
            
            // 5. returna envelope af NewsItemDto
            return Ok(authors);
        }


        // GET api/authors/2
        [HttpGet("/api/authors/{authorId}")]
        public ActionResult<string> getNewsItemById(int authorId)
        {
            AuthorDto author = _authorService.getAuthorById(authorId);

            // adding get single reference
            //category.addReference("self", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            //category.addReference("edit", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            //category.addReference("delete", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            author.addReference("self", "new link");
            author.addReference("edit", "new link");
            author.addReference("delete", "new link");
            author.addReference("newsItems", "should be object of news");
            author.addReference("newsItemsDetailed", "should be object list of detailed news");

            return Ok(author);
        }

        // GET api/authors/2/newsItems
        [HttpGet("/api/authors/{authorId}/newsItems")]
        public ActionResult<string> getAuthorNews(int authorId)
        {
            // Find authors news
            List<NewsItemDetailDto> newsList = _relationService.getRelationsByAuthorId(authorId)
                .Select( item => _newsService.getNewsItemById(item.newsId)).ToList();


            // adding get single reference
            //category.addReference("self", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            //category.addReference("edit", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            //category.addReference("delete", new ExpandoObject().TryAdd("href", "api/categories/" + category.Id));
            foreach(NewsItemDetailDto item in newsList) {
                item.addReference("self", "new link");
                item.addReference("edit", "new link");
                item.addReference("delete", "new link");
                item.addReference("authors", "should be object LIST of authors");
                item.addReference("categories", "should be object LIST of categories");
            }
            
            return Ok(newsList);
        }
    }
}