using AutoElon.Data.Entities;
using AutoElon.Data.Models;

namespace AutoElon.Data.Mappers;

public static class Mapper
{
    public static AnnouncementModel ToModel(this Announcement announcement)
    {
        var model = new AnnouncementModel(
            announcement.Id,
            announcement.Marka,
            announcement.Description,
            announcement.Price,
            announcement.Distance,
            announcement.Color,
            announcement.ManifacturedDate,
            announcement.PhotoUrl,
            announcement.OilType,
            announcement.Region,
            announcement.District,
            announcement.PhoneNumber,
            announcement.CategoryId
        );
        return model;
    }    
}