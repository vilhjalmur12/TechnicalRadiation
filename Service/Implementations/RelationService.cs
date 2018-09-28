using TechnicalRadiation.Models;
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
    }
    
}