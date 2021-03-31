using FeriaVirtual.Application.Users.Commands.ChangeStatus;
using FeriaVirtual.Application.Users.Commands.Update;
using FeriaVirtual.Application.Users.Services.Create;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.SeedWork;
using System;

namespace Application.Test.Users
{
    public class UserMother
    {
        public static User GetAValidUser()
        {
            var validUser = new User("Juanito", "Perez Pereira", "12345678-9", 1,
            "j.perezp", "@Password.1234@", "j.perezp@email.com");
            return validUser;
        }


        public static CreateUserCommand GetValidCreateUserCommand() =>
            CreateUserCommandBuilder.GetInstance()
                .Firstname("Juanito")
                .Lastname("Perez Pereira")
                .Dni("12345678-9")
                .ProfileId(1)
                .Username("j.perezp")
                .Password("@Password.1234@")
                .Email("j.perezp@email.com")
                .Build();


        public static object GetNullCommand() =>
            null;

        public static UpdateUserCommand GetValidUpdateUserCommand() =>
            UpdateUserCommandBuilder.GetInstance()
                .UserId(Guid.NewGuid().ToString())
                .Firstname("Juanito")
                .Lastname("Perez Pereira")
                .Dni("12345678-9")
                .ProfileId(1)
                .CredentialId(Guid.NewGuid().ToString())
                .Username("j.perezp")
                .Password("@Password.1234@")
                .Email("j.perezp@email.com")
            .IsActive(1)
                .Build();

        public static ChangeUserStatusCommand GetValidEnableUserStatusCommand() =>
            new(GuidGenerator.NewSequentialGuid().ToString(), 1);

        public static ChangeUserStatusCommand GetValidDisableUserStatusCommand() =>
            new(GuidGenerator.NewSequentialGuid().ToString(), 0);

        public static ChangeUserStatusCommand CreateUserStatusCommand(int isActive) =>
            new(GuidGenerator.NewSequentialGuid().ToString(), isActive);


    }
}
