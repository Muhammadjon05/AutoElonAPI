using AutoElon.Data.Entities;
using AutoElon.Data.Models;

namespace AutoElon.Data.Mappers;

public static class Mapper
{
    public static AnnouncementModel ToModel(this Announcement announcement)
    {
        var model = new AnnouncementModel()
        {

            Id = announcement.Id,
            Marka = announcement.Marka,
            Description = announcement.Description,
            Price = announcement.Price,
            Distance = announcement.Distance,
            Color = announcement.Color,
            CreatedDate = announcement.ManifacturedDate,
            Photo = announcement.PhotoUrl,
            OilType = announcement.OilType,
            Region = announcement.Region,
            District = announcement.District,
            PhoneNumber = announcement.PhoneNumber,
            CategoryId = announcement.CategoryId
        };
        return model;
    }

    public static CategoryModel ToModel(this Category category)
    {
        var model = new CategoryModel()
        {
            Id = category.Id,
            Name = category.Name,
            ParentId = category.ParentId,
        };
        return model;
    }
}