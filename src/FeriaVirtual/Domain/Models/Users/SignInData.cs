using FeriaVirtual.Domain.SeedWork.ValueObjects;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users
{
    public class SignInData
        : ValueObject
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }

        public SignInData(string username, string password)
        {
            Username = username;
            Password = password;
        }


        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Username;
            yield return Password;
        }


        public Dictionary<string, object> GetPrimitives() =>
            new()
            {
                { "Username", Username },
                { "Password", Password }
            };


    }
}
