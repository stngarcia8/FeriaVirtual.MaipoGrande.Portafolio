using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchById
{
    public class SearchEmployeeByIdQueryHandler
        : IQueryHandler<SearchEmployeeByIdQuery, SearchEmployeeByIdResponse>
    {
        private readonly IEmployeeRepository _repository;


        public SearchEmployeeByIdQueryHandler(IEmployeeRepository repository) =>
            _repository = repository;


        public async Task<SearchEmployeeByIdResponse> Handle(SearchEmployeeByIdQuery query)
        {
            if (query is null)
                throw new InvalidEmployeeServiceException("Identificador de empleado inválido.");

            var response = await _repository.SearchById<SearchEmployeeByIdResponse>(query.Id);
            if(response is null)
                throw new InvalidEmployeeServiceException("No es posible encontrar un empleado con el identificador especificado.");

            return response;
        }


    }
}
