using TechnicalRadiation.Models;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalRadiation.Service
{
    public interface NewsItemService
    {
        List<NewsItemDto> getLightweight();
        NewsItemDetailDto getNewsItemById(int id);
         
    }
}