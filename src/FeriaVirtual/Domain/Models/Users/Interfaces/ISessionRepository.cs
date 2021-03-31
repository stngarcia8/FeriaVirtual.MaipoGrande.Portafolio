using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface ISessionRepository
    {
        TResponse SignIn<TResponse>
            (string username, string password)
            where TResponse : IQueryResponseBase;


    }
}
