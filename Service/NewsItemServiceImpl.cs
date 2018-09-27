using TechnicalRadiation.Models;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalRadiation.Service
{
    public class NewsItemServiceImpl : NewsItemService
    {
        // initialize the repository

        // initializer public NewsItemServiceImpl
        public NewsItemServiceImpl() {

        }

        // getLightweight
        public List<NewsItemDto> getLightweight() {
            return getTestItems().OrderBy(c => c.PublishDate).Select(item => 
                new NewsItemDto {
                    Id = item.Id,
                    Title = item.Title,
                    ImgSource = item.ImgSoruce,
                    ShortDescription = item.ShortDescription
                }
            ).ToList();
        }
        

        // getDetails

        // createNewsItem

        // updateNewsItem

        // deleteNewsItem


        // TEST function
        private List<NewsItem> getTestItems() {
            return new List<NewsItem> {
                new NewsItem {
                    Id = 1,
                    Title = "New item 1",
                    ImgSoruce = "some new source 1",
                    ShortDescription = "Short description 1",
                    LongDescription = "Long description 1",
                    PublishDate = new System.DateTime()
                },
                new NewsItem {
                    Id = 2,
                    Title = "New item 2",
                    ImgSoruce = "some new source 2",
                    ShortDescription = "Short description 2",
                    LongDescription = "Long description 2",
                    PublishDate = new System.DateTime()
                }
            };
        }
    }
}