using AutoElon.Data.Entities;
using AutoElon.Data.FileHelper;
using AutoElon.Data.Mappers;
using AutoElon.Data.Models;
using AutoElon.Data.Providers;
using ProductAPI.Repositories;

namespace ProductAPI.Managers;

public class AnnouncementManager 
{
    private readonly IAnnouncementRepository _repository;
    private readonly UserProvider _userProvider;
    public AnnouncementManager(IAnnouncementRepository repository, UserProvider userProvider)
    {
        _repository = repository;
        _userProvider = userProvider;
    }

    public async Task<AnnouncementModel> AddAnnouncement(AnnouncementDto dto)
    {
        var model = new Announcement()
        {
            Marka = dto.Marka,
            Description = dto.Description,
            Price = dto.Price,
            Distance = dto.Distance,
            Color = dto.Color,
            ManifacturedDate = dto.CreatedDate,
            OilType = dto.OilType,
            Region = dto.Region,
            PhotoUrl = await Helper.SaveProduct(dto.Photo),
            District = dto.District,
            CategoryId = dto.CategoryId,
            PhoneNumber = dto.PhoneNumber,
        };
        await _repository.AddAnnouncement(model);
        var userCar = new AnnouncementUser()
        {
            AnnouncementId = model.Id,
            UserId = _userProvider.UserId
        };
        await _repository.AddAnnouncementUser(userCar);
        return model.ToModel();
    }
    public async Task<AnnouncementModel> GetAnnouncementById(Guid announcementId)
    {
        var model = await _repository.GetAnnouncementById(announcementId);
        return model.ToModel();
    }

    public async Task DeleteAnnouncement(Guid announcementId)
    {
        await _repository.DeleteAnnouncement(announcementId);
    }

    public async Task UpdateAnnouncement(Announcement announcement)
    {
        await _repository.UpdateAnnouncement(announcement);
    }
}