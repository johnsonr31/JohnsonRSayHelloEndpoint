// Richard Johnson
// 10-25-22
// This api will take the user's name and return it when they include their name in the URL
// Peer Review: 

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    // The route is how the user will get to the right part of the API. They need to include their name in the URL
    [Route("Hello/{name}")]

    public string SayHello(string name)
    {
        // This will take the user's name from the URL and print it along with some other text
        return $"Hello, {name}. I hope you're having a nice day today";
    }
}
