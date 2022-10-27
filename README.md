# JohnsonRSayHelloEndpoint

Richard Johnson
Last edited: 10-27-22

HOW TO USE: Open the project in VSCode and click "Debug and Run." After it loads the API and opens a page in your browser, go to the debug console and look through the white text there until you find the version of the URL with "HTTP" in the front instead of "HTTPS." Copy this and paste it into an API platform such as Postman, then add "SayHello/hello/{name}", but type your name instead of {name}. Then hit enter, and you should see a message with your name, or whatever you typed if it wasn't your name, written there.

Peer Review: Pedro Castaneda - I like the simplicity of the function and the cleanliness of the code. I think you did a great job with naming conventions in your route and controller.cs file. The only thing I would suggest giving a try is validation for the input to make sure they do not input an integer. Other than that excellent job!
