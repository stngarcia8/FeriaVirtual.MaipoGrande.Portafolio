using FeriaVirtual.Domain.Models.Users;

namespace Domain.Test.Models.Users.ObjectMother
{
    public class CreateCredentialMother
    {
        public static Credential GetAValidCredential()
        {
            var validCredential = new Credential("j.perezp", "@Password.1234@", "email@dominio.com");
            return validCredential;
        }


        public static Credential GetCredentialWithInvalidUsernameValues(string username)
        {
            var invalidCredential = new Credential(username, "@Password.1234@", "email@dominio.com");
            return invalidCredential;
        }


        public static Credential GetCredentialWithInvalidPasswordValues(string password)
        {
            var invalidCredential = new Credential("j.perezp", password, "email@dominio.com");
            return invalidCredential;
        }


        public static Credential GetCredentialWithInvalidEmailValues(string email)
        {
            var invalidCredential = new Credential("j.perezp", "@Password.1234@", email);
            return invalidCredential;
        }


    }
}
