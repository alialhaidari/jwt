using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetUserData()
    {
        return Ok(new { Message = "Secure user data" });
    }
}
