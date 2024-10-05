using Microsoft.AspNetCore.Mvc;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("Demo")] //Identificador
public class DemoController : ControllerBase
{
    [HttpGet("getstring")] //Identificador
    public string GetNombre()
    {
        return "vaxidrex.com";    
    }
}