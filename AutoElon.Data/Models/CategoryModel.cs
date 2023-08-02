using AutoElon.Data.Entities;

namespace AutoElon.Data.Models;

public class CategoryModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } 
    public Guid? ParentId { get; set; }
    
}