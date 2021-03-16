using FeriaVirtual.Domain.SeedWork;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface ISessionRepository
    {
        TViewModel SignIn<TViewModel>
            (string username, string password)
            where TViewModel : IViewModelBase;


    }
}
