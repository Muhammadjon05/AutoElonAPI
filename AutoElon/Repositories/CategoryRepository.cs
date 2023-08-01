using AutoElon.Data.AppDbContext;
using AutoElon.Data.Entities;
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

    public async Task<Category> GetCategoryById(int categoryId)
    {
        var category = await _identityDbContext.Categories.FirstOrDefaultAsync(i => i.Id == categoryId);
        return category;
    }

    public async Task DeleteCategory(int categoryId)
    {
        var category = await GetCategoryById(categoryId);
        _identityDbContext.Categories.Remove(category);
        await _identityDbContext.SaveChangesAsync();
        
    }
}