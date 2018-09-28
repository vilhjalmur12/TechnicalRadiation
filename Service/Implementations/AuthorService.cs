using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Repository.Interfaces;
using TechnicalRadiation.Repository.Implementations;

namespace TechnicalRadiation.Service.Implementations
{
    public class AuthorService : IAuthorService
    {
        IAuthorRepository _authorRepository = new AuthorRepository();

        public List<AuthorDto> getAllAuthors() {
            return _authorRepository.getAllAuthors().Select(item => new AuthorDto
            {
                Id = item.Id,
                Name = item.Name
            }).ToList();
        }

        public AuthorDetailDto getAuthorById(int id) {
            Author tmp = _authorRepository.getAllAuthors().Where(a => a.Id == id).SingleOrDefault();
            return new AuthorDetailDto {
                Id = tmp.Id,
                Name = tmp.Name,
                ProfileImgSource = tmp.ProfileImgSource,
                Bio = tmp.Bio
            };
        }

        public int createAuthor(AuthorInputModel model) {
            return _authorRepository.createAuthor(model);
        }

        public void updateAuthorById(AuthorInputModel inputModel,int id) {
            _authorRepository.updateAuthorById(inputModel, id);
        }

        public void deleteAuthorById(int authorId) {
            _authorRepository.deleteAuthorById(authorId);
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