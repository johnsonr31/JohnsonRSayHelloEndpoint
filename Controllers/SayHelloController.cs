// Richard Johnson
// 10-25-22
// This api will take the user's name and return it when they include their name in the URL
// Peer Review: Pedro Castaneda - I like the simplicity of the function and the cleanliness of the code. I think you did a great job with naming conventions in your route and controller.cs file. The only thing I would suggest giving a try is validation for the input to make sure they do not input an integer. Other than that excellent job!

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
