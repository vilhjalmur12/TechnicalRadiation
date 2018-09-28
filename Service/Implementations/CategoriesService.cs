using TechnicalRadiation.Models;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Service.Interfaces;

namespace TechnicalRadiation.Service.Implementations
{
    public class CategoriesService : ICategoriesService
    {
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