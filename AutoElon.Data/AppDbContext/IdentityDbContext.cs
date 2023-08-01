using AutoElon.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoElon.Data.AppDbContext;

public class IdentityDbContext: DbContext
{
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {      
        modelBuilder.Entity<Category>()
        .HasOne(c => c.Parent)
        .WithMany(c => c.Children)
        .HasForeignKey(c => c.ParentId)
        .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<User>().HasMany(i => i.AnnouncementUsers).WithOne(i => i.User);
        modelBuilder.Entity<Announcement>().HasMany(i => i.AnnouncementUsers).WithOne(i => i.Announcement);

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<AnnouncementUser> AnnouncementUsers { get; set; }
    public DbSet<Category> Categories{ get; set; }
}