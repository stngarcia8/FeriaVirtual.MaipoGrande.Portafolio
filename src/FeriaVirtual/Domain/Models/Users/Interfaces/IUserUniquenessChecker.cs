using System.Threading.Tasks;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface IUserUniquenessChecker
    {
        bool UsernameIsUnique { get; }
        bool DniIsUnique { get; }
        bool EmailIsUnique { get; }


        Task Check
            (string username, string dni, string email);


    }
}