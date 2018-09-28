using TechnicalRadiation.Models;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Service.Interfaces;

namespace TechnicalRadiation.Service.Implementations
{
    public class AuthorService : IAuthorService
    {
        public List<AuthorDto> getAllAuthors() {
            return getAuthors().Select(item => new AuthorDto
            {
                Id = item.Id,
                Name = item.Name
            }).ToList();
        }

        public AuthorDto getAuthorById(int id) {
            return getAllAuthors().Where( a => a.Id == id).SingleOrDefault();
        }


        // TEST funciton
        private List<Author> getAuthors() {
            return new List<Author> {
                new Author 
                {
                    Id = 1,
                    Name = "John Doe",
                    ProfileImgSource = "Johns image source",
                    Bio = "My name is john doe and i love writing books"
                },
                new Author
                {
                    Id = 2,
                    Name = "Villi Villason",
                    ProfileImgSource = "villi image source",
                    Bio = "My name is villi villason"
                }
            };
        }
    }
}