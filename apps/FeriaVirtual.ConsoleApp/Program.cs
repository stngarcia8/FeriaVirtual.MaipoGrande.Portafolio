using System;
using FeriaVirtual.IOC;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            RegisterServices();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void RegisterServices()
        {
            var serviceCollection = new ServiceCollection();
            DependencyContainer.RegisterServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
