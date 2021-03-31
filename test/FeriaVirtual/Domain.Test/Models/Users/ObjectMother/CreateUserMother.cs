using FeriaVirtual.Domain.Models.Users;

namespace Domain.Test.Models.Users.ObjectMother
{
    public class CreateUserMother
    {
        public static User GetAValidUser()
        {
            var validUser = new User("Juanito", "Perez Pereira", "12345678-9", 1,
            "j.perezp", "@Password.1234@", "j.perezp@email.com");
            return validUser;
        }

        public static User GetUserWithInvalidFirstname(string firstname)
        {
            var invalidUser = new User(firstname, "Perez Pereira", "12345678-9", 1,
            "j.perezp", "@Password.1234@", "j.perezp@email.com");
            return invalidUser;
        }


        public static User GetUserWithInvalidLasttname(string lastname)
        {
            var invalidUser = new User("juanito", lastname, "12345678-9", 1,
            "j.perezp", "@Password.1234@", "j.perezp@email.com");
            return invalidUser;
        }


        public static User GetUserWithInvalidDni(string dni)
        {
            var invalidUser = new User("juanito", "Perez Pereira", dni, 1,
            "j.perezp", "@Password.1234@", "j.perezp@email.com");
            return invalidUser;
        }


        public static User GetUserWithInvalidProfileId(int profileId)
        {
            var invalidUser = new User("juanito", "Perez Pereira", "12345678-9", profileId,
            "j.perezp", "@Password.1234@", "j.perezp@email.com");
            return invalidUser;
        }


    }
}
