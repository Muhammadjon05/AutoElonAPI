using AutoElon.Data.Entities;

namespace ProductAPI.Repositories;

public interface ICategoryRepository
{
    Task AddCategory(Category category);
    Task<Category> GetCategoryById(Guid categoryId);
    Task DeleteCategory(Guid categoryId);

    Task<bool> IsExist(string username);

}