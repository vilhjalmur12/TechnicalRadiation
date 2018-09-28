using System.Collections.Generic;
using TechnicalRadiation.Models;

namespace TechnicalRadiation.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> getAllCategories();
        Category getCategoryById(int categoryId);
        int createCategory(CategoryInputModel item);
        bool deleteCategoryById(int categoryId);
        void updateCategoryById(CategoryInputModel category, int categoryId);
    }
}