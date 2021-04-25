using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Queries.UniquenessChecker
{
    public class UserUniquenessCheckerQueryHandler
        : IQueryHandler<UserUniquenessCheckerQuery, UserUniquenessCheckerResponse>
    {
        private readonly IUserRepository _repository;


        public UserUniquenessCheckerQueryHandler(IUserRepository repository)
            => _repository = repository;


        public async Task<UserUniquenessCheckerResponse> Handle
            (UserUniquenessCheckerQuery query)
        {
            if(query is null)
                throw new InvalidUserServiceException($"Parámetros de consulta inválidos { query }");
            if(query.UserId is null)
                return await _repository.UserUniquenessChecker<UserUniquenessCheckerResponse>(
                    query.Username, query.Dni, query.Email
                    );
            else
                return await _repository.UserUniquenessChecker<UserUniquenessCheckerResponse>(
                    query.UserId, query.Username,
                    query.Dni, query.Email
                    );
        }


    }
}
