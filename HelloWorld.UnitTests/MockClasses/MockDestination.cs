using HelloWorld.Application.Interfaces;
using HelloWorld.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.UnitTests.MockClasses
{
    class MockDestination : IHelloWorldDestination
    {
        private string _helloWorldValue = "Goodbye";

        public void OutputHelloWorld()
        {
            var helloWorld = new HelloWorldModel();
            _helloWorldValue = helloWorld.ToString();
        }

        public override string ToString()
        {
            return _helloWorldValue;
        }
    }
}
