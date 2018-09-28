using System.Collections.Generic;
using TechnicalRadiation.Models;
using TechnicalRadiation.Repository;

namespace TechnicalRadiation.Repository.Interfaces
{
    public interface INewsItemRepository
    {
        List<NewsItem> GetAllNews();
        NewsItem GetNewsById(int newsId);
        bool createNews(NewsItemInputModel item);
        bool deleteNewsById(int id);
        void updateById(NewsItemInputModel news, int id);
    }
}