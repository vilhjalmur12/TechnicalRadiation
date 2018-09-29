using System.Collections.Generic;
using System.Globalization;
using TechnicalRadiation.Models.Entities;
using System.Linq;
using System;

namespace TechnicalRadiation.Data
{
    
    public static class DbContext
    {
        private const string DATE_FORMAT = "dd/MM/yyyy hh:mm:tt";

        public static List<NewsItem> NewsItems { get => _newsmodels; set => _newsmodels = value; }
        public static List<Author> Authors { get => _authormodels; set => _authormodels = value; }
        public static List<Category> Categorys { get => _categorymodels; set => _categorymodels = value; }
        public static List<NewsCategoryRelation> NewsCategoryRelation {
            get => _categoryNewsRelation; set => _categoryNewsRelation = value;
        }
        public static List<NewsAuthorRelation> NewsAuthorRelations {
            get => _authorNewsRelations; set => _authorNewsRelations = value;
        }

        /*
            The plan was to use DateTime.Parse(string) in initializing the Publish date.
            However we ended up with european time parsing vs. american problem so one Mac 
            computer wanted different parsing for the string and a windows computer another. We
            even tried the ParseExact function but had differrent issues then. All requirement are
            still met under the services for ordering by the date we just needed to switch to 
            DateTime.Now in initializing.
         */
        private static List<NewsItem> _newsmodels = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Title of the news article 1",
                ImgSource = "https://example.com/news-item/1.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 2,
                Title = "Title of the news article 2",
                ImgSource = "https://example.com/news-item/2.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 3,
                Title = "Title of the news article 3",
                ImgSource = "https://example.com/news-item/3.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 4,
                Title = "Title of the news article 4",
                ImgSource = "https://example.com/news-item/4.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 5,
                Title = "Title of the news article 5",
                ImgSource = "https://example.com/news-item/5.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 6,
                Title = "Title of the news article 6",
                ImgSource = "https://example.com/news-item/6.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 7,
                Title = "Title of the news article 7",
                ImgSource = "https://example.com/news-item/7.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 8,
                Title = "Title of the news article 8",
                ImgSource = "https://example.com/news-item/8.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 9,
                Title = "Title of the news article 9",
                ImgSource = "https://example.com/news-item/9.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 10,
                Title = "Title of the news article 10",
                ImgSource = "https://example.com/news-item/10.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 11,
                Title = "Title of the news article 11",
                ImgSource = "https://example.com/news-item/11.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 12,
                Title = "Title of the news article 12",
                ImgSource = "https://example.com/news-item/12.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 13,
                Title = "Title of the news article 13",
                ImgSource = "https://example.com/news-item/13.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 14,
                Title = "Title of the news article 14",
                ImgSource = "https://example.com/news-item/14.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 15,
                Title = "Title of the news article 15",
                ImgSource = "https://example.com/news-item/15.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 16,
                Title = "Title of the news article 16",
                ImgSource = "https://example.com/news-item/16.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 17,
                Title = "Title of the news article 17",
                ImgSource = "https://example.com/news-item/17.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 18,
                Title = "Title of the news article 18",
                ImgSource = "https://example.com/news-item/18.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 19,
                Title = "Title of the news article 19",
                ImgSource = "https://example.com/news-item/19.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 20,
                Title = "Title of the news article 20",
                ImgSource = "https://example.com/news-item/20.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 21,
                Title = "Title of the news article 21",
                ImgSource = "https://example.com/news-item/21.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 22,
                Title = "Title of the news article 22",
                ImgSource = "https://example.com/news-item/22.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 23,
                Title = "Title of the news article 23",
                ImgSource = "https://example.com/news-item/23.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 24,
                Title = "Title of the news article 24",
                ImgSource = "https://example.com/news-item/24.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 25,
                Title = "Title of the news article 25",
                ImgSource = "https://example.com/news-item/25.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
            },
            new NewsItem
            {
                Id = 26,
                Title = "Title of the news article 25",
                ImgSource = "https://example.com/news-item/25.jpg",
                ShortDescription = "A short description",
                LongDescription = "A long description",
                PublishDate = DateTime.Now,
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

        private static List<NewsCategoryRelation> _categoryNewsRelation = new List<NewsCategoryRelation>
        {
                new NewsCategoryRelation
                {
                    Id = 1,
                    newsId = 12,
                    categoryId = 2
                },
                new NewsCategoryRelation
                {
                    Id = 2,
                    newsId = 12,
                    categoryId = 1
                },
                new NewsCategoryRelation
                {
                    Id = 3,
                    newsId = 4,
                    categoryId = 1
                },
                new NewsCategoryRelation
                {
                    Id = 4,
                    newsId = 5,
                    categoryId = 2
                },
                new NewsCategoryRelation
                {
                    Id = 5,
                    newsId = 6,
                    categoryId = 2
                }  
        };

        private static List<NewsAuthorRelation> _authorNewsRelations = new List<NewsAuthorRelation>
        {
                new NewsAuthorRelation 
                {
                    Id = 1,
                    newsId = 12,
                    authorId = 2
                },
                new NewsAuthorRelation 
                {
                    Id = 2, 
                    newsId = 14,
                    authorId = 2
                },
                new NewsAuthorRelation 
                {
                    Id = 3, 
                    newsId = 16,
                    authorId = 1
                },
                new NewsAuthorRelation 
                {
                    Id = 4, 
                    newsId = 17,
                    authorId = 2
                },
                new NewsAuthorRelation 
                {
                    Id = 5, 
                    newsId = 1,
                    authorId = 2
                },
                new NewsAuthorRelation 
                {
                    Id = 6, 
                    newsId = 1,
                    authorId = 1
                },
        };
    }
}