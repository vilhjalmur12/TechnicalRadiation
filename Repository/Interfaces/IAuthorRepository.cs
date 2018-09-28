using System.Collections.Generic;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;


namespace TechnicalRadiation.Repository.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> getAllAuthors();
        Author getAuthorById(int authorId);
        int createAuthor(AuthorInputModel item);
        bool deleteAuthorById(int authorId);
        void updateAuthorById(AuthorInputModel author, int authorId);
        
    }
}