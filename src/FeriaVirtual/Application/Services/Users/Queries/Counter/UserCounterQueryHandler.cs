using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Users.Queries.Counter
{
    public class UserCounterQueryHandler
        : IQueryHandler<UserCounterQuery, UserCounterResponse>
    {
        private readonly IUserRepository _repository;


        public UserCounterQueryHandler(IUserRepository repository) =>
            _repository = repository;


        public UserCounterResponse Handle(UserCounterQuery query) =>
            new() {
                Total = _repository.CountAllUsers()
            };


    }
}
