using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using HelloWorld.Application.Interfaces;
using HelloWorld.UnitTests.MockClasses;
using HelloWorld.Application.Models;

namespace HelloWorld.UnitTests
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorld_Model_Returns_HelloWorld()
        {
            // arrange
            var testResult = "Goodbye";
            var helloWorldModel = new HelloWorldModel();

            // action 
            testResult = helloWorldModel.ToString();

            // assert
            Assert.AreEqual("Hello World", testResult);
        }

        [TestMethod]
        public void Destination_Outputs_HelloWorld_Via_Source()
        {
            // arrange
            var testResult = "Goodbye";
            IHelloWorldDestination helloWorldDestination;
            IHelloWorldSource helloWorldSource;

            // action 
            using (var container = InitializeUnity())
            {
                helloWorldDestination = container.Resolve<IHelloWorldDestination>();
                helloWorldSource = container.Resolve<IHelloWorldSource>(
                    new DependencyOverride<IHelloWorldDestination>(helloWorldDestination));
                helloWorldSource.SendHelloWorld();
                testResult = helloWorldDestination.ToString();
            }

            // assert
            Assert.AreEqual("Hello World", testResult);
        }

        public static IUnityContainer InitializeUnity()
        {
            var container = new UnityContainer();
            // Sources
            container.RegisterType<IHelloWorldSource, MockSource>();

            // Destinations
            container.RegisterType<IHelloWorldDestination, MockDestination>();
            return container;
        }
    }
}
