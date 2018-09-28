using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.InputModels;
using System.Collections.Generic;


namespace TechnicalRadiation.Service.Interfaces
{
    public interface IAuthorService
    {
         List<AuthorDto> getAllAuthors();
         AuthorDetailDto getAuthorById(int id);
         int createAuthor(AuthorInputModel model);
         void updateAuthorById(AuthorInputModel inputModel,int id);
         void deleteAuthorById(int authorId);
    }
}