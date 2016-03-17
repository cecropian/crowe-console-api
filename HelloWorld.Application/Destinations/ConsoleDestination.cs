using HelloWorld.Application.Interfaces;
using HelloWorld.Application.Models;

namespace HelloWorld.Application.Destinations
{
    public class ConsoleDestination : IHelloWorldDestination
    {

        public void OutputHelloWorld()
        {
            var helloWorld = new HelloWorldModel();
            System.Console.WriteLine(helloWorld.ToString());
        }
    }
}
