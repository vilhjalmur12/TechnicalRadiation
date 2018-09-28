using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Data;
using TechnicalRadiation.Models;
using TechnicalRadiation.Repository.Interfaces;

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
        public bool createAuthor(AuthorInputModel item)
        {
            DbContext.Authors.Add(new Author {
                Id = DbContext.Authors.Last().Id + 1,
                Name = item.Name,
                ProfileImgSource = item.ProfileImgSource,
                Bio = item.Bio
            });
           return true; 
        }
        //Delete author by Id
        public bool deleteAuthorById(int authorId)
        {
            return DbContext.Authors.Remove(DbContext.Authors.Where(c => c.Id == authorId).SingleOrDefault());
        }

        //Update author by id
        public void updateAuthorById(AuthorInputModel author, int authorId)
        {
            var updateAuthor = DbContext.Authors.FirstOrDefault(c => c.Id == authorId);

            if(updateAuthor == null) {
                return;
                //throw some exception
            }
            updateAuthor.Name = author.Name;
            updateAuthor.Bio =author.Bio;
            updateAuthor.ProfileImgSource = author.ProfileImgSource;
        }
        
    }
}