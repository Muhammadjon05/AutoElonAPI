namespace AutoElon.Data.Exceptions;

public class AnnouncementNotFoundException : Exception
{
    public AnnouncementNotFoundException(string message): base($"Announcement not found with id: {message}")
    {
        
    }
    
}