﻿using AutoElon.Data.Entities.Enums;

namespace AutoElon.Data.Entities;

public class User
{ 
    public Guid UserId { get; set; }
    public required string Firstname { get; set; }
    public string? Lastname { get; set; }
    public required string Username { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    public ERole UserRole { get; set; }
    
    public virtual List<AnnouncementUser> AnnouncementUsers { get; set; }
}