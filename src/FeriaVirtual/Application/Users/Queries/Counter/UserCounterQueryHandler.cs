using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Queries.Counter
{
    public class UserCounterQueryHandler
        :IQueryHandler<UserCounterQuery, UserCounterResponse>
    {
        private readonly IUserRepository _repository;


        public UserCounterQueryHandler(IUserRepository repository) =>
            _repository = repository;



        public UserCounterResponse Handle(UserCounterQuery query)
        {
            var counter = _repository.CountAllUsers();
            return new UserCounterResponse
            {
                Total = counter
            };
            
        }


    }
}
