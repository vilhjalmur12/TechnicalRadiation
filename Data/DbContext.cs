using System.Collections.Generic;
using TechnicalRadiation.Models;
using System.Linq;
using System;

namespace TechnicalRadiation.Data
{
    public static class DbContext
    {
        private static List<NewsItem> _newsmodels = new List<NewsItem>
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
            new NewsItem
            {
                Id = 4,
                Title = "Title of the news article 4",
                ImgSoruce = "https://example.com/news-item/4.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:04"),
            },
            new NewsItem
            {
                Id = 5,
                Title = "Title of the news article 5",
                ImgSoruce = "https://example.com/news-item/5.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:05"),
            },
            new NewsItem
            {
                Id = 6,
                Title = "Title of the news article 6",
                ImgSoruce = "https://example.com/news-item/6.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:06"),
            },
            new NewsItem
            {
                Id = 7,
                Title = "Title of the news article 7",
                ImgSoruce = "https://example.com/news-item/7.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:07"),
            },
            new NewsItem
            {
                Id = 8,
                Title = "Title of the news article 8",
                ImgSoruce = "https://example.com/news-item/8.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:08"),
            },
            new NewsItem
            {
                Id = 9,
                Title = "Title of the news article 9",
                ImgSoruce = "https://example.com/news-item/9.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:09"),
            },
            new NewsItem
            {
                Id = 10,
                Title = "Title of the news article 10",
                ImgSoruce = "https://example.com/news-item/10.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("24/07/2018 10:00:10"),
            },
        };
    }
}