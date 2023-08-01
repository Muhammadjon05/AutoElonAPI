using AutoElon.Data.Entities;
using ProductAPI.Repositories;

namespace ProductAPI.Managers;

public class CategoryManager 
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

  

    public Task<Category> GetCategoryById(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCategory(int categoryId)
    {
        throw new NotImplementedException();
    }
}