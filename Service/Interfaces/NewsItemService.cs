using TechnicalRadiation.Models.DTO;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Models.InputModels;

namespace TechnicalRadiation.Service.Interfaces
{
    public interface NewsItemService
    {
        List<NewsItemDto> getLightweight();
        NewsItemDetailDto getNewsItemById(int id);
        int createNewsItem(NewsItemInputModel inputModel);
        void updateNewsItemById(NewsItemInputModel model, int id);
        void deleteNewsById(int id);
    }
}