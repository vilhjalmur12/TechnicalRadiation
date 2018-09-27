using TechnicalRadiation.Repository.Interfaces;
using TechnicalRadiation.Data;
using TechnicalRadiation.Models;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalRadiation.Repository.Implementations
{
    public class NewsItemRepository : INewsItemRepository
    {
        //List<NewsItem> _db = DbContext.NewsItems;
        //Get all news
        public List<NewsItem> GetAllNews()
        {
            return DbContext.NewsItems.OrderBy(c => c.PublishDate).ToList();    
      
        }
        //Get news by id
        public NewsItem GetNewsById(int newsId)
        {
            return DbContext.NewsItems.Where(c => c.Id == newsId).SingleOrDefault();
        }

        //Create
        //DeleteById
        //UpdateById
        public List<NewsItem> Create

    }
}