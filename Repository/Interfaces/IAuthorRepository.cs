using System.Collections.Generic;
using TechnicalRadiation.Models;

namespace TechnicalRadiation.Repository.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> getAllAuthors();
        Author getAuthorById(int authorId);
        bool createAuthor(AuthorInputModel item);
        bool deleteAuthorById(int authorId);
        void updateAuthorById(AuthorInputModel author, int authorId);
        
    }
}