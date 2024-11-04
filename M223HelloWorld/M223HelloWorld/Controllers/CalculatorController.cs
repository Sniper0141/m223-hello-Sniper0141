using Microsoft.AspNetCore.Mvc;

namespace M223HelloWorld.Controllers;

[ApiController]
[Route("calculator")]
public class CalculatorController : ControllerBase
{
    [HttpGet("add/{firstNumber}/{secondNumber}")]
    public IActionResult Add(int firstNumber, int secondNumber)
    {
        return Ok(firstNumber + secondNumber);
    }
}