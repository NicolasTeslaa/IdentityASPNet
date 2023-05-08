using Identity.API.ViewModels;
using Identity.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers;

[ApiController]
[Route("api/users/")]

public class UserController : ControllerBase
{
    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateUserViewModel userViewModel)
    {
        try
        {
            return Ok();
        }
        catch (DomainException ex)
        {

            throw;
        }
        catch (Exception)
        {

            return StatusCode(500, "Erro");
        }
    }
}