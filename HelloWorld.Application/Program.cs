using HelloWorld.Application.Interfaces;
using Microsoft.Practices.Unity;

namespace HelloWorld.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Source and Destination could be arguments passed to main
            var source = "Console";
            var destination = "Console";

            System.Console.WriteLine($"Source = {source}; Destination = {destination}");

            using (var container = BootStrapper.Initialize())
            {
                var helloWorldDestination = container.Resolve<IHelloWorldDestination>(destination);
                var helloWorldSource = container.Resolve<IHelloWorldSource>(source, 
                    new DependencyOverride<IHelloWorldDestination>(helloWorldDestination));
                helloWorldSource.SendHelloWorld();
            }
        }
    }
}
