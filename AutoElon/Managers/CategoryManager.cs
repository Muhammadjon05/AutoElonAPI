using AutoElon.Data.Entities;
using AutoElon.Data.Exceptions;
using AutoElon.Data.Mappers;
using AutoElon.Data.Models;
using ProductAPI.Repositories;

namespace ProductAPI.Managers;

public class CategoryManager 
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<CategoryModel> AddCategory(CategoryDto dto)
    {
        var result = await _categoryRepository.IsExist(dto.Name);
        if (!result)
        {
            var model = new Category()
            {
                Name = dto.Name,
                ParentId = dto.ParentId,
            };
            await _categoryRepository.AddCategory(model);
            return model.ToModel();
        }
        else
        {
            throw new CategoryNameIsExistException(dto.Name);
        }
    } 
    

    public  async Task<CategoryModel> GetCategoryById(Guid categoryId)
    {
        var category = await _categoryRepository.GetCategoryById(categoryId);
        return category.ToModel();

    }

    public async Task DeleteCategory(Guid categoryId)
    {
        await _categoryRepository.DeleteCategory(categoryId);
    }

 
}