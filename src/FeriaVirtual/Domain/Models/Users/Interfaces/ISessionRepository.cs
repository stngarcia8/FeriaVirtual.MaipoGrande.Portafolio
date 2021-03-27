using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface ISessionRepository
    {
        TViewModel SignIn<TViewModel>
            (string username, string password)
            where TViewModel : IQueryResponseBase;


    }
}
