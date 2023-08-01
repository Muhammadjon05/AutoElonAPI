namespace AutoElon.Data.Entities;

public class AnnouncementUser
{  
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
    public Guid AnnouncementId { get; set; }
    public virtual Announcement Announcement { get; set; }

}