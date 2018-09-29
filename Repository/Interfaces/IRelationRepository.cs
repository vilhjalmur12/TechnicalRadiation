using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Data;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repository.Interfaces;
using TechnicalRadiation.Models.Exceptions;

namespace TechnicalRadiation.Repository.Interfaces
{
    public interface IRelationRepository
    {
         List<NewsAuthorRelation> getAllAuthorNewsRelations();
         List<NewsCategoryRelation> getAllNewsCategoryRelations();
         void createNewsCategoryRelation(int _newsId, int _categoryId);
         void createAuthorNewsRelation(int _newsId, int _authorId);
    }
}