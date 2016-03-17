using HelloWorld.Application.Destinations;
using HelloWorld.Application.Interfaces;
using HelloWorld.Application.Sources;
using Microsoft.Practices.Unity;

namespace HelloWorld.Application
{
    public static class BootStrapper
    {
        public static IUnityContainer Initialize()
        {
            var container = new UnityContainer();
            // Sources
            container.RegisterType<IHelloWorldSource, ConsoleSource>();
            container.RegisterType<IHelloWorldSource, ConsoleSource>("Console");
            container.RegisterType<IHelloWorldSource, ClassSource>("Class");

            // Destinations
            container.RegisterType<IHelloWorldDestination, ConsoleDestination>();
            container.RegisterType<IHelloWorldDestination, ConsoleDestination>("Console");
            return container;
        }
    }
}
