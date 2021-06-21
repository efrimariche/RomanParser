using Microsoft.Extensions.DependencyInjection;
using RomanParserCore;
using RomanParserCore.Interface;

namespace RomanParserConsole
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRomanParserService, RomanParserService>();
            services.AddTransient<IRomanParserBusiness, RomanParserBusiness>();
        }
    }
}
