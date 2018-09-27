using System.Collections.Generic;
using TechnicalRadiation.Models;
using System.Linq;
using System;

namespace TechnicalRadiation.Data
{
    public static class DbContext
    {
        private static List<NewsItem> _models = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Title of the news article 1",
                ImgSoruce = "https://example.com/news-item/1.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:00"),
            },
            new NewsItem
            {
                Id = 2,
                Title = "Title of the news article 2",
                ImgSoruce = "https://example.com/news-item/2.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:02"),
            },
            new NewsItem
            {
                Id = 3,
                Title = "Title of the news article 3",
                ImgSoruce = "https://example.com/news-item/3.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:03"),
            },
        };
    }
}