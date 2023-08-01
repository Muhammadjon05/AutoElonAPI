namespace AutoElon.Data.Models;

public class AnnouncementModel
{
    public Guid Id { get; set; }
    public string Marka { get; set; }
    public string Description { get; set; }
    public long  Price { get; set; }
    public long Distance { get; set; }
    public string  Color { get; set; }
    public DateTime CreatedDate{ get; set; }
    public string Photo { get; set; }
    public string  OilType { get; set; }
    public string Region { get; set; }
    public string District { get; set; }
    public string PhoneNumber { get; set; }
    public int CategoryId { get; set; }

    public AnnouncementModel
    (
            Guid Id,
            string Marka,
            string Description,
            long  Price,
            long Distance,
            string  Color,
            DateTime CreatedDate,
            string Photo,
            string  OilType,
            string Region,
            string District,
            string PhoneNumber,
            int CategoryId
            )
    {
        this.Id = Id;
        this.Marka = Marka;
        this.Description = Description;
        this.Price = Price;
        this.Distance = Distance;
        this.Color = Color;
        this.CreatedDate = CreatedDate;
        this.Photo = Photo;
        this.OilType = OilType;
        this.Region = Region;
        this.District = District;
        this.PhoneNumber = PhoneNumber;
        this.CategoryId = CategoryId;
        }
}