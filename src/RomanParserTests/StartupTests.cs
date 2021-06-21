using Microsoft.Extensions.DependencyInjection;
using RomanParserConsole;
using RomanParserCore.Interface;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace RomanParserTests
{
    [ExcludeFromCodeCoverage]
    public class StartupTests
    {
        private readonly IServiceProvider ServiceProvider;
        private readonly int InstanceCount;

        public StartupTests()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            Startup.ConfigureServices(serviceCollection);
            InstanceCount = serviceCollection.Count;
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        [Fact]
        public void Should_Check_Injected_Instance_Existance()
        {
            Assert.Equal(2, InstanceCount);
            Assert.NotNull(ServiceProvider.GetService<IRomanParserService>());
            Assert.NotNull(ServiceProvider.GetService<IRomanParserBusiness>());
        }

    }
}




