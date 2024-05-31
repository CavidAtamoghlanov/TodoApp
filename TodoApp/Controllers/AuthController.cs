using Microsoft.AspNetCore.Mvc;
using TodoApp.Models.Dtos;

namespace TodoApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginRequestDto loginDto)
    {
        throw new NotImplementedException();
    }
}
