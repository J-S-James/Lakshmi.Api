using Microsoft.AspNetCore.Mvc;

namespace Lakshmi.Api.Web.Controllers.V1;

[Route("v1/api/[controller]")]
[ApiController]
public class AccountController : Controller
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}
