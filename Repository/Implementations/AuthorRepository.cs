using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Data;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repository.Interfaces;
using TechnicalRadiation.Models.Exceptions;

namespace TechnicalRadiation.Repository.Implementations
{
    public class AuthorRepository : IAuthorRepository
    {
        //Get all authors
        public List<Author> getAllAuthors()
        {
            return DbContext.Authors.ToList();
        }

        //Get authors by id
        public Author getAuthorById(int authorId)
        {
            return DbContext.Authors.Where(c => c.Id == authorId).SingleOrDefault();
        }

        //Create new author
        public int createAuthor(AuthorInputModel item)
        {
            int newId = DbContext.Authors.Last().Id + 1;
            DbContext.Authors.Add(new Author {
                Id = newId,
                Name = item.Name,
                ProfileImgSource = item.ProfileImgSource,
                Bio = item.Bio
            });
           return newId; 
        }

        //Delete author by Id
        public bool deleteAuthorById(int authorId)
        {
            Author author = DbContext.Authors.Where(c => c.Id == authorId).SingleOrDefault();
            if (author == null) {
                throw new ResourceNotFoundException();
            }
            return DbContext.Authors.Remove(author);
        }

        //Update author by id
        public void updateAuthorById(AuthorInputModel author, int authorId)
        {
            var updateAuthor = DbContext.Authors.FirstOrDefault(c => c.Id == authorId);

            if(updateAuthor == null) {
                throw new ResourceNotFoundException();
            }
            updateAuthor.Name = author.Name;
            updateAuthor.Bio =author.Bio;
            updateAuthor.ProfileImgSource = author.ProfileImgSource;
        }
        
    }
}