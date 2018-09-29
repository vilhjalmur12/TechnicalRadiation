using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.InputModels;
using System.Collections.Generic;

namespace TechnicalRadiation.Service.Interfaces
{
    public interface ICategoriesService
    {
         List<CategoryDto> getAllCategories();
        CategoryDto GetCategoryById(int id);
        int createCategory(CategoryInputModel inputModel);
        void updateCategoryById(int categoryId,CategoryInputModel inputModel);
        void deleteCategoryById(int categoryId);
    }

}