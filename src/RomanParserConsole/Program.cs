using Microsoft.Extensions.DependencyInjection;
using RomanParserCore.Interface;

namespace RomanParserConsole
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = CreateServiceProvider();

            var service = serviceProvider.GetService<IRomanParserService>();
            
           var result = service.RomanParser(args[0]);

            System.Console.WriteLine($"Roman to Integer parse: \n  {args[0]} ====> {result}");

        }

        public static ServiceProvider CreateServiceProvider()
        {
            var services = new ServiceCollection();

            Startup.ConfigureServices(services);

            var servicesProvider = services.BuildServiceProvider();

            return servicesProvider;
        }
    }
}
