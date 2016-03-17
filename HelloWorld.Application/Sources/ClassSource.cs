using HelloWorld.Application.Interfaces;

namespace HelloWorld.Application.Sources
{
    public class ClassSource : IHelloWorldSource
    {
        private IHelloWorldDestination _helloWorldDestination;

        public ClassSource(IHelloWorldDestination helloWorldDestination)
        {
            _helloWorldDestination = helloWorldDestination;
        }

        public void SendHelloWorld()
        {
            _helloWorldDestination.OutputHelloWorld();
        }
    }
}
