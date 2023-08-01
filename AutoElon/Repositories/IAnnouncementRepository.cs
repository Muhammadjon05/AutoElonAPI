using AutoElon.Data.Entities;
using AutoElon.Data.Models;

namespace ProductAPI.Repositories;

public interface IAnnouncementRepository
{
    Task AddAnnouncement(Announcement announcement);
    Task AddAnnouncementUser(AnnouncementUser announcement);
    Task<Announcement> GetAnnouncementById(Guid announcementId);
    Task DeleteAnnouncement(Guid announcementId);
    Task UpdateAnnouncement(Announcement announcement);
}