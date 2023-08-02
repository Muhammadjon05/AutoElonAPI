namespace AutoElon.Data.Entities;

public class Category
{
    public Guid Id {get; set;}
    public string Name { get; set; } 
    public Guid? ParentId { get; set; }
    public virtual Category? Parent { get; set; }
    public virtual List<Category> Children { get; set; }
}