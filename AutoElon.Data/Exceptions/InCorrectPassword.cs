namespace AutoElon.Data.Exceptions;

public class InCorrectPassword : Exception
{
    public InCorrectPassword(string password): base($"Given password:{password} is incorrect")
    {
        
    }
    
}