using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Queries.SearchById
{
    public class SearchUserByIdQueryHandler
        : IQueryHandler<SearchUserByIdQuery, SearchUserByIdResponse>
    {
        private readonly IUserRepository _repository;


        public SearchUserByIdQueryHandler(IUserRepository repository) =>
            _repository = repository;


        public async Task<SearchUserByIdResponse> Handle(SearchUserByIdQuery query)
        {
            if (query is null)
                throw new InvalidUserServiceException("Identificador de usuario inválido.");
            var response = await _repository.SearchById<SearchUserByIdResponse>(query.Id);
            if (response is null)
                throw new InvalidUserServiceException("El Usuario solicitado no existe.");
            return response;
        }


    }
}
