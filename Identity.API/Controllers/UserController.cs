using AutoMapper;
using Identity.API.Utilites;
using Identity.API.ViewModels;
using Identity.Core.Exceptions;
using Identity.Services.DTO;
using Identity.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers;

[ApiController]
[Route("api/users/")]

public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateUserViewModel userViewModel)
    {
        try
        {
            var userDTO = _mapper.Map<UserDTO>(userViewModel);
            var userCreated = await _userService.Create(userDTO);
            return Ok(new ResultViewModel
            {
                Message = "usuario criado com sucesso",
                Sucess = true,
                Data = userCreated
            });
        }
        catch (DomainException ex)
        {
            return BadRequest(Responses.DomainErrorMessage(ex.Message, ex.Errors));
        }
        catch (Exception)
        {

            return StatusCode(500, Responses.ApplicationErrorMessage());
        }
    }
}