using System.Collections.Generic;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Repository;

namespace TechnicalRadiation.Repository.Interfaces
{
    public interface INewsItemRepository
    {
        List<NewsItem> GetAllNews();
        NewsItem GetNewsById(int newsId);
        int createNews(NewsItemInputModel item);
        void deleteNewsById(int id);
        void updateById(NewsItemInputModel news, int id);
    }
}