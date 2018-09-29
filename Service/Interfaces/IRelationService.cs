using TechnicalRadiation.Models.Entities;
using System.Collections.Generic;

namespace TechnicalRadiation.Service.Interfaces
{
    public interface IRelationService
    {
        List<NewsAuthorRelation> getRelationsByAuthorId(int id);
        List<NewsAuthorRelation> getAutherNewsRelationByNewsId(int id);
        List<NewsCategoryRelation> getNewsCateoryRelationByNewsId(int id);
        void setAuthorNewsRelations(int authorId, int newsId);
        void setNewsCategoryRelations(int newsId, int categoryId);
    }
}