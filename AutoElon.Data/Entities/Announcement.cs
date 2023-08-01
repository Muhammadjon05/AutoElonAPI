namespace AutoElon.Data.Entities;


#pragma warning disable CS8618

public class Announcement
{
    public Guid Id { get; set; }
    public string Marka { get; set; }
    public string? Description { get; set; }
    public long  Price { get; set; }
    public long Distance { get; set; }
    public string  Color { get; set; }
    public DateTime ManifacturedDate{ get; set; }
    public string PhotoUrl { get; set; }
    public string  OilType { get; set; }
    public string Region { get; set; }
    public string District { get; set; }
    public string PhoneNumber { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public virtual List<AnnouncementUser> AnnouncementUsers { get; set; }
    

}

#pragma warning restore CS8618
