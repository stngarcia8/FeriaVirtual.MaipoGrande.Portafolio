using System;
using System.Collections.Generic;
using System.Text;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Application.Users.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.IOC.Extension.DependencyInjection
{
    public static class Application
    {
        public static IServiceCollection AddApplication
            (this IServiceCollection services)
        {
            services.AddScoped<ICreateUserServiceHandler, CreateUserServiceHandler>();
            return services;
        }


    }
}
