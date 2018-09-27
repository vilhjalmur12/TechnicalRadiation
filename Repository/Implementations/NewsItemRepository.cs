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
        public bool createNews(NewsItemInputModel item) {
            DbContext.NewsItems.Add(new NewsItem {
                Id = DbContext.NewsItems.Last().Id + 1,
                Title = item.Title,
                ImgSource = item.ImgSource,
                ShortDescription = item.ShortDescription,
                LongDescription = item.LongDescription,
                PublishDate = item.PublishDate
            });

            // TODO: finna leið til að keyra á true/false
            return true;
        }

        public bool deleteNewsById(int id) {
            return DbContext.NewsItems.Remove(DbContext.NewsItems.Where(c => c.Id == id).SingleOrDefault());
        }

        

    }
}