using System.Security.Cryptography;
using System.Text;


namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Security
{
    public class EncriptSha1
        : IEncriptor
    {
        private readonly string _password;


        private EncriptSha1(string password) =>
            _password = password ?? string.Empty;

        public static EncriptSha1 CreateEncriptor(string password) =>
            new EncriptSha1(password);

        public string GetEncriptedPassword()
        {
            if(string.IsNullOrEmpty(_password)) {
                return string.Empty;
            }
            var sha1 = SHA1.Create();
            var originalPassword = Encoding.Default.GetBytes(_password);
            var hash = sha1.ComputeHash(originalPassword);
            var encriptedString = new StringBuilder();
            foreach(var i in hash) {
                encriptedString.AppendFormat("{0:x2}", i);
            }
            return encriptedString.ToString();
        }


    }
}
