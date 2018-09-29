using TechnicalRadiation.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Repository.Implementations;
using TechnicalRadiation.Repository.Interfaces;

namespace TechnicalRadiation.Service.Implementations
{
    public class RelationService : IRelationService
    {
        private IRelationRepository _relationRepository = new RelationRepository();

        public List<NewsAuthorRelation> getRelationsByAuthorId(int id) {
            return _relationRepository.getAllAuthorNewsRelations().Where( t => t.authorId == id).ToList();
        }

        public List<NewsAuthorRelation> getAutherNewsRelationByNewsId(int id) {
            return _relationRepository.getAllAuthorNewsRelations().Where( t => t.newsId == id).ToList();
        }

        public List<NewsCategoryRelation> getNewsCateoryRelationByNewsId(int id) {
            return _relationRepository.getAllNewsCategoryRelations().Where( t => t.newsId == id).ToList();
        }

        public void setAuthorNewsRelations(int authorId, int newsId) {
            _relationRepository.createAuthorNewsRelation(newsId, authorId);
        }

        public void setNewsCategoryRelations(int newsId, int categoryId) {
            _relationRepository.createNewsCategoryRelation(newsId, categoryId);
        }
    }
    
}