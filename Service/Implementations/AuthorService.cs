using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.Entities;
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

        public AuthorDetailDto getAuthorById(int id) {
            Author tmp = getAuthors().Where(a => a.Id == id).SingleOrDefault();
            return new AuthorDetailDto {
                Id = tmp.Id,
                Name = tmp.Name,
                ProfileImgSource = tmp.ProfileImgSource,
                Bio = tmp.Bio
            };
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