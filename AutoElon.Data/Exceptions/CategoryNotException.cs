namespace AutoElon.Data.Exceptions;

public class CategoryNotException : Exception
{
    public CategoryNotException(string message) : base($"Category not found with id :{message}")
    {
        
    }
    
}