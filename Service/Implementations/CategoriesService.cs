using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Service.Interfaces;
using TechnicalRadiation.Repository.Implementations;
using TechnicalRadiation.Repository.Interfaces;

namespace TechnicalRadiation.Service.Implementations
{
    public class CategoriesService : ICategoriesService
    {
        private ICategoryRepository _categoryRepository = new CategoryRepository();

        public List<CategoryDto> getAllCategories() {
            return getTestItems().Select(item => new CategoryDto
            {
                Id = item.Id,
                Name = item.Name,
                Slug = item.Slug
            }).ToList();
        }

        public CategoryDto GetCategoryById(int id) {
            Category category = getTestItems().Where( c => c.Id == id).SingleOrDefault();
            return new CategoryDto{
                Id = category.Id,
                Name = category.Name,
                Slug = category.Slug
            };
        }

        public int createCategory(CategoryInputModel inputModel) {
            return _categoryRepository.createCategory(inputModel);
        }


        public void updateCategoryById(int categoryId,CategoryInputModel inputModel) {
            _categoryRepository.updateCategoryById(inputModel, categoryId);
        }

        public void deleteCategoryById(int categoryId) {
            _categoryRepository.deleteCategoryById(categoryId);
        }

            // TEST function
            private List<Category> getTestItems() {
            return new List<Category> {
                new Category {
                    Id = 1,
                    Name = "Category 1",
                    Slug = "category 1"
                },
                new Category {
                    Id = 2,
                    Name = "Category 2",
                    Slug = "category 2"
                }
            };
        }
    }
}