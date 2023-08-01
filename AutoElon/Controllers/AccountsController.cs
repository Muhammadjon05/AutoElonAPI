﻿using AutoElon.Data.Exceptions;
using AutoElon.Data.Models;
using AutoElon.Data.Providers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Managers;

namespace ProductAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountsController : ControllerBase
{
    private readonly UserManager _userManager;
    private ILogger<AccountsController> _logger;
    private readonly UserProvider _userProvider;

    public AccountsController(UserManager userManager, 
        ILogger<AccountsController> logger,
        UserProvider userProvider)
    {
        _userManager = userManager;
        _logger = logger;
        _userProvider = userProvider;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] CreateUserModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
            var user = await _userManager.Register(model);
            return Ok(user);
        }
        catch (UsernameExistException e)
        {
            return BadRequest("UserName is already exists");
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginUserModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var token = await _userManager.Login(model);
            return Ok(new { Token = token });
        }
        catch (UserNotFoundException e)
        {
            return BadRequest("User not found ");
        }
        catch (InCorrectPassword e)
        {
            return BadRequest("Given password is incorrect");
        }
    }


    [HttpGet("profile")]
    [Authorize]
    public async Task<IActionResult> Profile()
    {
        var userId = _userProvider.UserId;
        try
        {
            var user = await _userManager.GetUser(userId);
            return Ok(user);

        }
        catch (UserNotFoundException e)
        {
            return Unauthorized();
        }
    }
    [HttpPost("{userName}")]
    public async Task<IActionResult> GetUser(string userName)
    {
        try
        {
            var user = await _userManager.GetUser(userName);
            return Ok(user);
        }
        catch (UserNotFoundException e)
        {
            return BadRequest("User not found");
        }
    
    }
}