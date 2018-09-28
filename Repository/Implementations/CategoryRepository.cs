using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Data;
using TechnicalRadiation.Models;

namespace TechnicalRadiation.Repository.Implementations
{
    public class CategoryRepository
    {
        //Get all categorys
        public List<Category> getAllCategories()
        {
            return DbContext.Categorys.ToList();
        }
        //Get category by id
        public Category getCategoryById(int categoryId)
        {
            return DbContext.Categorys.Where(c => c.Id == categoryId).SingleOrDefault();
        }
        //Create new category
        public int createCategory(CategoryInputModel item)
        {
            int newId = DbContext.Categorys.Last().Id + 1;
            DbContext.Categorys.Add(new Category {
                Id = newId,
                Name = item.Name,
                ParentCategoryId = item.ParentCategoryId, // defaults to 0
                /*
                Should be generated by making the Name above
                lowercase and join the words together with (-)
                Example:
                Science Fiction == science-fiction
                */
                Slug = item.Slug
            });
           return newId; 
        }
        //Delete category by Id
        public bool deleteCategoryById(int categoryId)
        {
            return DbContext.Categorys.Remove(DbContext.Categorys.Where(c => c.Id == categoryId).SingleOrDefault());
        }

        //Update category by id
        public void updateCategoryById(CategoryInputModel category, int categoryId)
        {
            var updateCategory = DbContext.Categorys.FirstOrDefault(c => c.Id == categoryId);

            if(updateCategory == null) {
                return;
                //throw some exception
            }
            updateCategory.Name = category.Name;
            updateCategory.ParentCategoryId = category.ParentCategoryId;
            updateCategory.Slug = category.Slug;
        }
        
    }
}