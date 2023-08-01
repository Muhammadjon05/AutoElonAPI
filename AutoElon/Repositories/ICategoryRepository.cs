using AutoElon.Data.Entities;

namespace ProductAPI.Repositories;

public interface ICategoryRepository
{
    Task AddCategory(Category category);
    Task<Category> GetCategoryById(int categoryId);
    Task DeleteCategory(int categoryId);
    
}