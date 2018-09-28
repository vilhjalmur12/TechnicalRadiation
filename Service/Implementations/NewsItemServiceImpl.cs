using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Data;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Repository.Interfaces;
using TechnicalRadiation.Repository.Implementations;

namespace TechnicalRadiation.Service.Implementations
{
    public class NewsItemServiceImpl : NewsItemService
    {
        // initialize the repository
        private INewsItemRepository _newsRepository = new NewsItemRepository();

        // initializer public NewsItemServiceImpl
        public NewsItemServiceImpl() {

        }

        // getLightweight
        public List<NewsItemDto> getLightweight() {
            return _newsRepository.GetAllNews().OrderBy(c => c.PublishDate).Select(item => 
                new NewsItemDto {
                    Id = item.Id,
                    Title = item.Title,
                    ImgSource = item.ImgSource,
                    ShortDescription = item.ShortDescription
                }
            ).ToList();
        }

        // getDetails
        public NewsItemDetailDto getNewsItemById(int id) {
            foreach(NewsItem item in _newsRepository.GetAllNews()) {
                if (item.Id == id) {
                    return new NewsItemDetailDto 
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ImgSource = item.ImgSource,
                        ShortDescription = item.ShortDescription,
                        LongDescription = item.LongDescription,
                        PublishDate = item.PublishDate
                    };
                }
            }
            return null;
        }

        

        // createNewsItem
        public int createNewsItem(NewsItemInputModel inputModel) {
            return _newsRepository.createNews(inputModel);
        }

        // updateNewsItem

        // deleteNewsItem


        // TEST function
        private List<NewsItem> getTestItems() {
            return new List<NewsItem> {
                new NewsItem {
                    Id = 1,
                    Title = "New item 1",
                    ImgSource = "some new source 1",
                    ShortDescription = "Short description 1",
                    LongDescription = "Long description 1",
                    PublishDate = System.DateTime.Parse("07/24/2018 10:00:17")
                },
                new NewsItem {
                    Id = 2,
                    Title = "New item 2",
                    ImgSource = "some new source 2",
                    ShortDescription = "Short description 2",
                    LongDescription = "Long description 2",
                    PublishDate = System.DateTime.Parse("07/24/2018 10:00:18")
                }
            };
        }
    }
}