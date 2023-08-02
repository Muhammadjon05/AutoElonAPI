using AutoElon.Data.Exceptions;
using AutoElon.Data.Models;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Managers;

namespace ProductAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly CategoryManager _categoryManager;

    public CategoryController(CategoryManager categoryManager)
    {
        _categoryManager = categoryManager;
    }

    [HttpPost]
    public async Task<IActionResult> AddCategory(CategoryDto dto)
    {
        try
        {
            var category = await _categoryManager.AddCategory(dto);
            return Ok(category);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    } 
    

    [HttpGet("categoryId")]
    public  async Task<IActionResult> GetCategoryById(Guid categoryId)
    {
        try
        {
            var category = await _categoryManager.GetCategoryById(categoryId);
            return Ok(category);
        }
        catch (CategoryNotException e)
        {
            return BadRequest("Category not found");
        }

    }

    [HttpDelete("categoryId")]
    public async Task<IActionResult> DeleteCategory(Guid categoryId)
    {
        try
        {
            await _categoryManager.DeleteCategory(categoryId);
            return Ok();
        }
        catch (CategoryNotException e)
        {
            return BadRequest("Category not found");
        }
    }
    
}