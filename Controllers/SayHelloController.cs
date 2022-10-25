using Microsoft.AspNetCore.Mvc;

namespace JohnsonRSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]

    public string SayHello(string name)
    {
        return $"Hello there, {name}. I hope you're having a nice day today";
    }
}
