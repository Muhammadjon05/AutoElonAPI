using AutoElon.Data.Entities;
using AutoElon.Data.Exceptions;
using AutoElon.Data.Models;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Managers;

namespace ProductAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnnouncementController : ControllerBase
{
    private readonly AnnouncementManager _announcementManager;

    public AnnouncementController(AnnouncementManager announcementManager)
    {
        _announcementManager = announcementManager;
    }
    [HttpPost]
    public async Task<IActionResult> AddAnnouncement([FromForm]AnnouncementDto dto)
    {
        try
        {
            var result  = await _announcementManager.AddAnnouncement(dto);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    [HttpGet("announcementId")]
    public async Task<IActionResult> GetAnnouncementById(Guid announcementId)
    {
        try
        {
            var announcement = await _announcementManager.GetAnnouncementById(announcementId);
            return Ok(announcement);

        }
        catch (AnnouncementNotFoundException e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("announcementId")]
    public async Task<IActionResult> DeleteAnnouncement(Guid announcementId)
    {
        try
        {
            await _announcementManager.DeleteAnnouncement(announcementId);
            return Ok();
        }
        catch (AnnouncementNotFoundException e)
        {
            return BadRequest(e.Message);
        }
    }

    /*public async Task<IActionResult> UpdateAnnouncement(AnnouncementModel announcement)
    {
        try
        {
            await _announcementManager.UpdateAnnouncement(announcement);
        }
        catch (AnnouncementNotFoundException e)
        {
            return BadRequest(e.Message);
        }   
    }*/
    
}