using System;
using FeriaVirtual.Application.Users.Dto;

namespace FeriaVirtual.ConsoleApp.Users
{
    public class UserGenerator
    {

        private UserGenerator() { }

        public static UserGenerator BuildGenerator() =>
            new UserGenerator();

        public CreateUserDto NewUser()
        {
            return new CreateUserDto {
                Firstname = "Daniel",
                Lastname = "García Asathor",
                Dni = "12345678-8",
                ProfileId = 1,
                Username = "d.garcial",
                Password = "@Password.1234@",
                Email = "email@dominio.com"
            };
        }

        public UpdateUserDto ExistingUser()
        {
            return new UpdateUserDto {
                UserId = new Guid("ac9ce2f8-08e0-d8ab-d8dd-00b100bc0019"),
                Firstname = "User-modified",
                Lastname = "For Test - modified",
                Dni = "09876543-0",
                ProfileId = 2,
                CredentialId = new Guid("94155b73-0866-d8aa-77dd-00b100bc0022"),
                Username = "user-modified.test",
                Password = "@Test.1234@",
                Email = "user.test.modified@domain.com",
                IsActive = 1
            };
        }

        public EnableOrDisableUserDto EnableUser()
        {
            return new EnableOrDisableUserDto {
                UserId = new Guid("ac9ce2f8-08e0-d8ab-d8dd-00b100bc0019")
            };
        }

        public EnableOrDisableUserDto DisableUser()
        {
            return new EnableOrDisableUserDto {
                UserId = new Guid("ac9ce2f8-08e0-d8ab-d8dd-00b100bc0019")
            };
        }




    }
}
