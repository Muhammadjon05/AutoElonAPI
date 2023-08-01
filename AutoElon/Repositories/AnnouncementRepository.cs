using AutoElon.Data.AppDbContext;
using AutoElon.Data.Entities;
using AutoElon.Data.Exceptions;
using AutoElon.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Repositories;

public class AnnouncementRepository : IAnnouncementRepository
{
    private readonly IdentityDbContext _identityDbContext;

    public AnnouncementRepository(IdentityDbContext identityDbContext)
    {
        _identityDbContext = identityDbContext;
    }

    public async Task AddAnnouncement(Announcement announcement)
    {
        await _identityDbContext.Announcements.AddAsync(announcement);
        await _identityDbContext.SaveChangesAsync();
    }

    public async Task AddAnnouncementUser(AnnouncementUser announcement)
    {
        await _identityDbContext.AnnouncementUsers.AddAsync(announcement);
        await _identityDbContext.SaveChangesAsync();
    }

    public async Task<Announcement> GetAnnouncementById(Guid announcementId)
    {
        var announcement =
            await _identityDbContext.Announcements.Where(i => i.Id == announcementId).FirstOrDefaultAsync();
        if (announcement == null)
        {
            throw new AnnouncementNotFoundException(announcementId.ToString());
        }
        return announcement;
    }

    public async Task DeleteAnnouncement(Guid announcementId)
    {
        var announcement = await GetAnnouncementById(announcementId);
        _identityDbContext.Announcements.Remove(announcement);
        await _identityDbContext.SaveChangesAsync();
    }

    public  async Task UpdateAnnouncement(Announcement announcement)
    {
         _identityDbContext.Announcements.Update(announcement);
         await _identityDbContext.SaveChangesAsync();
    }
}