using HelloWorld.Application.Interfaces;

namespace HelloWorld.Application.Sources
{
    public class ConsoleSource : IHelloWorldSource
    {
        private IHelloWorldDestination _helloWorldDestination;

        public ConsoleSource(IHelloWorldDestination helloWorldDestination)
        {
            _helloWorldDestination = helloWorldDestination;
        }

        public void SendHelloWorld()
        {
            System.Console.WriteLine("Press ENTER to print 'Hello World'");
            System.Console.ReadKey();
            _helloWorldDestination.OutputHelloWorld();
        }
    }
}
