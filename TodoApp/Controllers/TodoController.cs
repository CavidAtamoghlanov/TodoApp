using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class TodoController : ControllerBase
{
    [HttpGet("GetAll")]
    public  IActionResult GetAll()
    {
        return Ok("Hershey okaydir");
    }
}
