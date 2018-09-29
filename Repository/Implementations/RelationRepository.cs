using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Data;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repository.Interfaces;
using TechnicalRadiation.Models.Exceptions;

namespace TechnicalRadiation.Repository.Implementations
{
    public class RelationRepository : IRelationRepository
    {
        public List<NewsAuthorRelation> getAllAuthorNewsRelations(){
             return DbContext.NewsAuthorRelations;
         }

         public List<NewsCategoryRelation> getAllNewsCategoryRelations() {
             return DbContext.NewsCategoryRelation;
         }

         public void createNewsCategoryRelation(int _newsId, int _categoryId) {
            DbContext.NewsCategoryRelation.Add(new NewsCategoryRelation {
                Id = DbContext.NewsCategoryRelation.Last().Id + 1,
                newsId = _newsId,
                categoryId = _categoryId
            });
         }

         public void createAuthorNewsRelation(int _newsId, int _authorId) {
             DbContext.NewsAuthorRelations.Add(new NewsAuthorRelation {
                Id = DbContext.NewsAuthorRelations.Last().Id + 1,
                newsId = _newsId,
                authorId = _authorId
            });
         }
    }
}