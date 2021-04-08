using System.Threading.Tasks;

namespace FeriaVirtual.App.Desktop.Services.SignIn
{
    public interface ISigninService
    {
        Task SigninAsync(string username, string password);
    }
}