using TechnicalRadiation.Models;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Data;
using TechnicalRadiation.Service.Interfaces;

namespace TechnicalRadiation.Service.Implementations
{
    public class NewsItemServiceImpl : NewsItemService
    {
        // initialize the repository

        // initializer public NewsItemServiceImpl
        public NewsItemServiceImpl() {

        }

        // getLightweight
        public List<NewsItemDto> getLightweight() {
            return DbContext.NewsItems.OrderBy(c => c.PublishDate).Select(item => 
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
            foreach(NewsItem item in DbContext.NewsItems) {
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