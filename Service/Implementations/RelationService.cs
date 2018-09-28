using TechnicalRadiation.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Service.Interfaces;

namespace TechnicalRadiation.Service.Implementations
{
    public class RelationService : IRelationService
    {
        public List<NewsAuthorRelation> getRelationsByAuthorId(int id) {
            return getTestData().Where( t => t.authorId == id).ToList();
        }

        public List<NewsAuthorRelation> getAutherNewsRelationByNewsId(int id) {
            return getTestData().Where( t => t.newsId == id).ToList();
        }

        public List<NewsCategoryRelation> getNewsCateoryRelationByNewsId(int id) {
            return getNewsCatData().Where( t => t.newsId == id).ToList();
        }

        /* 
        public List<NewsAuthorRelation> getNewsAuthorRelByAuthorId(int id) {
            return getTestData().Where( r => r.authorId)
        }
        */

        private List<NewsAuthorRelation> getTestData() {
            return new List<NewsAuthorRelation> {
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
                }
            };

        }

        private List<NewsCategoryRelation> getNewsCatData() {
            return new List<NewsCategoryRelation> {
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
                }
            };
        }
    }
    
}