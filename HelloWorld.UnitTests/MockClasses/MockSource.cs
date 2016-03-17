using HelloWorld.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.UnitTests.MockClasses
{
    class MockSource : IHelloWorldSource
    {
        private IHelloWorldDestination _helloWorldDestination;

        public MockSource(IHelloWorldDestination helloWorldDestination)
        {
            _helloWorldDestination = helloWorldDestination;
        }

        public void SendHelloWorld()
        {
            _helloWorldDestination.OutputHelloWorld();
        }
    }
}
