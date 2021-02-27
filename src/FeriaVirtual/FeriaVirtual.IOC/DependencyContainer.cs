using System;
using System.Collections.Generic;
using System.Text;
using FeriaVirtual.IOC.Extension.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.IOC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure();
        }


    }
}
