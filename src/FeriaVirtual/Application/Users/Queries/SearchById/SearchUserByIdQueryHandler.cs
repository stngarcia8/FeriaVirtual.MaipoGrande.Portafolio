using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Queries.SearchById
{
    public class SearchUserByIdQueryHandler
        :IQueryHandler<SearchUserByIdQuery, SearchUserByIdResponse>
    {
        private readonly IUserRepository _repository;


        public SearchUserByIdQueryHandler(IUserRepository repository) =>
            _repository = repository;


        public SearchUserByIdResponse Handle(SearchUserByIdQuery query)
        {
            if(query is null)
                throw new InvalidUserServiceException("Identificador de usuario inválido.");
            var result = _repository.SearchById<SearchUserByIdResponse>(query.UserId);
            if(result is null)
                throw new InvalidUserServiceException("El Usuario solicitado no existe.");
            return result;
        }


    }
}
