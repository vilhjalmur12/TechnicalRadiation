using TechnicalRadiation.Models.Entities;
using System.Collections.Generic;

namespace TechnicalRadiation.Service.Interfaces
{
    public interface IRelationService
    {
         List<NewsAuthorRelation> getRelationsByAuthorId(int id);
    }
}