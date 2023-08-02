using AutoElon.Data.AppDbContext;
using AutoElon.Data.Entities;
using AutoElon.Data.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly IdentityDbContext _identityDbContext;

    public CategoryRepository(IdentityDbContext identityDbContext)
    {
        _identityDbContext = identityDbContext;
    }

    public  async Task AddCategory(Category category)
    {
        await _identityDbContext.Categories.AddAsync(category);
        await _identityDbContext.SaveChangesAsync();
    }

    public async Task<Category> GetCategoryById(Guid categoryId)
    {
        var category = await _identityDbContext.Categories.
            FirstOrDefaultAsync(i => i.Id == categoryId);
        if (category == null)
        {
            throw new CategoryNotException(categoryId.ToString());
        }
        return category;
    }
    

    public async Task DeleteCategory(Guid categoryId)
    {
        var category = await GetCategoryById(categoryId);
        _identityDbContext.Categories.Remove(category);
        await _identityDbContext.SaveChangesAsync();
        
    }
    public async Task<bool> IsExist(string username)
    {
        if (await _identityDbContext.Categories.AnyAsync(i => i.Name == username))
        {
            throw new CategoryNameIsExistException(username);
        }
        return false;
    }
}