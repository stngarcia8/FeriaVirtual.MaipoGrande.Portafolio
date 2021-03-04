using System;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.ConsoleApp.Users;
using FeriaVirtual.IOC;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Iniciando pruebas...!");
            try {

                Console.Write("Iniciando servicios...");
                var serviceProvider = DependencyContainer.GetServiceProvider();

                // Console.WriteLine("Creando usuario...");
                // var createUserService = serviceProvider.GetService<ICreateUserService>();
                // createUserService.Create(UserGenerator.BuildGenerator().NewUser());

                Console.WriteLine("Editando usuario existente...");
                var updateUserService = serviceProvider.GetService<IUpdateUserService>();
                updateUserService.Update(UserGenerator.BuildGenerator().ExistingUser());

                // Console.WriteLine("deshabilitando usuario existente...");
                // var enableUserService = serviceProvider.GetService<IEnableOrDisableUserService>();
                // enableUserService.DisableUser(UserGenerator.BuildGenerator().EnableUser());

                // Console.WriteLine("Habilitando usuario existente...");
                // var enableUserService = serviceProvider.GetService<IEnableOrDisableUserService>();
                // enableUserService.EnableUser(UserGenerator.BuildGenerator().EnableUser());


                Console.WriteLine("Usuario creado sin problemitas!");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Environment.Exit(0);
        }


    }
}
