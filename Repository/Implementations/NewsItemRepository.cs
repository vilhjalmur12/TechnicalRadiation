using TechnicalRadiation.Repository.Interfaces;
using TechnicalRadiation.Data;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using System.Collections.Generic;
using System.Linq;
using System;

namespace TechnicalRadiation.Repository.Implementations
{
    public class NewsItemRepository : INewsItemRepository
    {
        public List<NewsItem> GetAllNews()
        {
            return DbContext.NewsItems.OrderBy(c => c.PublishDate).ToList();    
      
        }
        //Get news by id
        public NewsItem GetNewsById(int newsId)
        {
            return DbContext.NewsItems.Where(c => c.Id == newsId).SingleOrDefault();
        }
        //Create news
        public int createNews(NewsItemInputModel item)
        {
            int newId = DbContext.NewsItems.Last().Id + 1;
            DbContext.NewsItems.Add(new NewsItem {
                Id = newId,
                Title = item.Title,
                ImgSource = item.ImgSource,
                ShortDescription = item.ShortDescription,
                LongDescription = item.LongDescription,
                PublishDate = item.PublishDate
            });

            // TODO: finna leið til að keyra á true/false
            return newId;
        }
        //Delete news by id
        public bool deleteNewsById(int id)
        {
            return DbContext.NewsItems.Remove(DbContext.NewsItems.Where(c => c.Id == id).SingleOrDefault());
        }
        //Update news by id
        public void updateById(NewsItemInputModel news, int id)
        {
            var updateNews = DbContext.NewsItems.FirstOrDefault(c => c.Id == id);

            if(updateNews == null ) {
                return; 
                //Throw some exception
            }
            //Update properties
            updateNews.Title = news.Title;
            updateNews.ImgSource = news.ImgSource;
            updateNews.ShortDescription = news.ShortDescription;
            updateNews.LongDescription = news.LongDescription;
            updateNews.PublishDate = DateTime.Now;
        }

    }
}