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

        public List<NewsItem> GetAllNews()
        {
            return DbContext.NewsItems.OrderBy(c => c.PublishDate).ToList();    
      
        }
    }
}