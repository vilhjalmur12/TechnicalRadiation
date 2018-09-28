using System.Collections.Generic;
using TechnicalRadiation.Models;
using System.Linq;
using System;

namespace TechnicalRadiation.Data
{
    public static class DbContext
    {
        public static List<NewsItem> NewsItems { get => _newsmodels; set => _newsmodels = value; }
        public static List<Author> Authors { get => _authormodels; set => _authormodels = value; }
        public static List<Category> Categorys { get => _categorymodels; set => _categorymodels = value; }
        private static List<NewsItem> _newsmodels = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Title of the news article 1",
                ImgSource = "https://example.com/news-item/1.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:00"),
            },
            new NewsItem
            {
                Id = 2,
                Title = "Title of the news article 2",
                ImgSource = "https://example.com/news-item/2.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:02"),
            },
            new NewsItem
            {
                Id = 3,
                Title = "Title of the news article 3",
                ImgSource = "https://example.com/news-item/3.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:03"),
            },
            new NewsItem
            {
                Id = 4,
                Title = "Title of the news article 4",
                ImgSource = "https://example.com/news-item/4.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:04"),
            },
            new NewsItem
            {
                Id = 5,
                Title = "Title of the news article 5",
                ImgSource = "https://example.com/news-item/5.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:05"),
            },
            new NewsItem
            {
                Id = 6,
                Title = "Title of the news article 6",
                ImgSource = "https://example.com/news-item/6.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:06"),
            },
            new NewsItem
            {
                Id = 7,
                Title = "Title of the news article 7",
                ImgSource = "https://example.com/news-item/7.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:07"),
            },
            new NewsItem
            {
                Id = 8,
                Title = "Title of the news article 8",
                ImgSource = "https://example.com/news-item/8.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:08"),
            },
            new NewsItem
            {
                Id = 9,
                Title = "Title of the news article 9",
                ImgSource = "https://example.com/news-item/9.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:09"),
            },
            new NewsItem
            {
                Id = 10,
                Title = "Title of the news article 10",
                ImgSource = "https://example.com/news-item/10.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:10"),
            },
            new NewsItem
            {
                Id = 11,
                Title = "Title of the news article 11",
                ImgSource = "https://example.com/news-item/11.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:11"),
            },
            new NewsItem
            {
                Id = 12,
                Title = "Title of the news article 12",
                ImgSource = "https://example.com/news-item/12.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:12"),
            },
            new NewsItem
            {
                Id = 13,
                Title = "Title of the news article 13",
                ImgSource = "https://example.com/news-item/13.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:13"),
            },
            new NewsItem
            {
                Id = 14,
                Title = "Title of the news article 14",
                ImgSource = "https://example.com/news-item/14.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:14"),
            },
            new NewsItem
            {
                Id = 15,
                Title = "Title of the news article 15",
                ImgSource = "https://example.com/news-item/15.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:15"),
            },
            new NewsItem
            {
                Id = 16,
                Title = "Title of the news article 16",
                ImgSource = "https://example.com/news-item/16.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:16"),
            },
            new NewsItem
            {
                Id = 17,
                Title = "Title of the news article 17",
                ImgSource = "https://example.com/news-item/17.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:17"),
            },
            new NewsItem
            {
                Id = 18,
                Title = "Title of the news article 18",
                ImgSource = "https://example.com/news-item/18.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:18"),
            },
            new NewsItem
            {
                Id = 19,
                Title = "Title of the news article 19",
                ImgSource = "https://example.com/news-item/19.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:19"),
            },
            new NewsItem
            {
                Id = 20,
                Title = "Title of the news article 20",
                ImgSource = "https://example.com/news-item/20.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:20"),
            },
            new NewsItem
            {
                Id = 21,
                Title = "Title of the news article 21",
                ImgSource = "https://example.com/news-item/21.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:21"),
            },
            new NewsItem
            {
                Id = 22,
                Title = "Title of the news article 22",
                ImgSource = "https://example.com/news-item/22.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:22"),
            },
            new NewsItem
            {
                Id = 23,
                Title = "Title of the news article 23",
                ImgSource = "https://example.com/news-item/23.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:23"),
            },
            new NewsItem
            {
                Id = 24,
                Title = "Title of the news article 24",
                ImgSource = "https://example.com/news-item/24.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:24"),
            },
            new NewsItem
            {
                Id = 25,
                Title = "Title of the news article 25",
                ImgSource = "https://example.com/news-item/25.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:25"),
            },
            new NewsItem
            {
                Id = 26,
                Title = "Title of the news article 25",
                ImgSource = "https://example.com/news-item/25.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Parse("07/24/2018 10:00:26"),
            }
        };

        private static List<Author> _authormodels = new  List<Author>
        {
            new Author
            {
                Id = 1,
                Name = "John Doe",
                ProfileImgSource = "https://example.com/authors/1.jpg",
                Bio = "My name is John Doe and I love writing Books!",
            },
            new Author
            {
                Id = 2,
                Name = "Jane Doe",
                ProfileImgSource = "https://example.com/authors/2.jpg",
                Bio = "My name is Jane Doe and I love writing Books!",
            }
        };

        private static List<Category> _categorymodels = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "Gadgets",
                Slug = "gadgets",
                ParentCategoryId = 0,

            },
            new Category
            {
                Id = 2,
                Name = "Politics",
                Slug = "politics",
                ParentCategoryId = 0,

            }
        };
    }
}