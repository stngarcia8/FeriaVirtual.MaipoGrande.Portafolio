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

                // Console.WriteLine("Editando usuario existente...");
                // var updateUserService = serviceProvider.GetService<IUpdateUserService>();
                // updateUserService.Update(UserGenerator.BuildGenerator().ExistingUser());

                // Console.WriteLine("deshabilitando usuario existente...");
                // var enableUserService = serviceProvider.GetService<IEnableOrDisableUserService>();
                // enableUserService.DisableUser(UserGenerator.BuildGenerator().EnableUser());

                // Console.WriteLine("Habilitando usuario existente...");
                // var enableUserService = serviceProvider.GetService<IEnableOrDisableUserService>();
                // enableUserService.EnableUser(UserGenerator.BuildGenerator().EnableUser());

                // Console.WriteLine("Listando usuario existente...");
                // var queryUserService = serviceProvider.GetService<IQueryUserService>();
                // var usuario = queryUserService.SearchById("08daae9c-d977-4234-a054-0b83918ed3e7");
                // Console.WriteLine(usuario);

                Console.WriteLine("Listando usuarios existente...");
                var queryUserService = serviceProvider.GetService<IQueryUserService>();
                bool ciclo = true;
                var pageNumber = 1;
                while (ciclo) {
                    var usuarios = queryUserService.SearchAll(pageNumber);
                    if(!usuarios.Count.Equals(0)) {
                        Console.WriteLine($"Pagina :{pageNumber.ToString()}");
                        foreach (var usuario in usuarios)
                            Console.WriteLine(usuario);
                        pageNumber++;
                    } else {
                        ciclo= false;
                    }
                }
                Console.WriteLine("Termine!!!!");





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
