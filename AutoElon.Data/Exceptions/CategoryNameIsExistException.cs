namespace AutoElon.Data.Exceptions;

public class CategoryNameIsExistException : Exception
{
    public CategoryNameIsExistException(string message): base($"Category name: {message} is exists")
    {
        
    }
    
}