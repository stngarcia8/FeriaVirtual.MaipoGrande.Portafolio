using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.SeedWork;
using System;

namespace Domain.Test.Models.Users.ObjectMother
{
    public class UpdateUserMother
    {
        private static Guid _userId;
        private static Guid _credentialId;


        private static void GenerateGuid()
        {
            _userId = GuidGenerator.NewSequentialGuid();
            _credentialId = GuidGenerator.NewSequentialGuid();
        }


        public static User GetAValidUser()
        {
            GenerateGuid();
            var validUser = new User(_userId, "Juanito", "Perez Pereira", "12345678-9", 1,
                _credentialId, "j.perezp", "@Password.1234@", "j.perezp@email.com", 1);
            return validUser;
        }


        public static User GetUserWithEmptyUserId()
        {
            GenerateGuid();
            var validUser = new User(Guid.Empty, "Juanito", "Perez Pereira", "12345678-9", 1,
                _credentialId, "j.perezp", "@Password.1234@", "j.perezp@email.com", 1);
            return validUser;
        }

        public static User GetUserWithInvalidFirstname(string firstname)
        {
            GenerateGuid();
            var invalidUser = new User(_userId, firstname, "Perez Pereira", "12345678-9", 1,
                _credentialId, "j.perezp", "@Password.1234@", "j.perezp@email.com", 1);
            return invalidUser;
        }


        public static User GetUserWithInvalidLasttname(string lastname)
        {
            GenerateGuid();
            var invalidUser = new User(_userId, "juanito", lastname, "12345678-9", 1,
                _credentialId, "j.perezp", "@Password.1234@", "j.perezp@email.com", 1);
            return invalidUser;
        }


        public static User GetUserWithInvalidDni(string dni)
        {
            GenerateGuid();
            var invalidUser = new User(_userId, "juanito", "Perez Pereira", dni, 1,
                _credentialId, "j.perezp", "@Password.1234@", "j.perezp@email.com", 1);
            return invalidUser;
        }


        public static User GetUserWithInvalidProfileId(int profileId)
        {
            GenerateGuid();
            var invalidUser = new User(_userId, "juanito", "Perez Pereira", "12345678-9", profileId,
                _credentialId, "j.perezp", "@Password.1234@", "j.perezp@email.com", 1);
            return invalidUser;
        }


    }
}
