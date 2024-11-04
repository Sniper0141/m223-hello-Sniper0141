using Microsoft.AspNetCore.Mvc;

namespace M223HelloWorld.Controllers;

[ApiController]
[Route("hello")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult HelloWorld()
    {
        return Ok("Hello Modul 223");
    }
}