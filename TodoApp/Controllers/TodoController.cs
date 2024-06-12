using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TodoApp.BackgroundServices;

namespace TodoApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController : ControllerBase
{
    [HttpGet("GetAll")]
    public  IActionResult GetAll()
    {
        return Ok("Hershey okaydir");
    }
}
