using TechnicalRadiation.Models.DTO;
using System.Collections.Generic;


namespace TechnicalRadiation.Service.Interfaces
{
    public interface IAuthorService
    {
         List<AuthorDto> getAllAuthors();
         AuthorDto getAuthorById(int id);
    }
}