using TechnicalRadiation.Models.DTO;
using System.Collections.Generic;

namespace TechnicalRadiation.Service.Interfaces
{
    public interface ICategoriesService
    {
         List<CategoryDto> getAllCategories();
        CategoryDto GetCategoryById(int id);
    }

}