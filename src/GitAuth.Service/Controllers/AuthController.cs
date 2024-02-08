using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    [HttpGet("Login")]
    public IActionResult Login()
    {
        return Challenge(new AuthenticationProperties { RedirectUri = "/" }, "GitHub");
    }

    [HttpGet("Logout")]
    public IActionResult Logout()
    {
        return SignOut(new AuthenticationProperties { RedirectUri = "/" }, "Cookies");
    }
}
