using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Queries.Counter
{
    public class UserCounterQueryHandler
        : IQueryHandler<UserCounterQuery, UserCounterResponse>
    {
        private readonly IUserRepository _repository;


        public UserCounterQueryHandler(IUserRepository repository) =>
            _repository = repository;


        public async Task<UserCounterResponse> Handle(UserCounterQuery query) =>
            new() {
                Total = await _repository.CountAllUsers()
            };


    }
}
