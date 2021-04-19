using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface ISessionRepository
    {
        Task<TResponse> SignIn<TResponse>
            (string username, string password)
            where TResponse : IQueryResponseBase;


    }
}
