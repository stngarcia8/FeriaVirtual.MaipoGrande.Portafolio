using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchById
{
    public class SearchEmployeeByIdQueryHandler
        : IQueryHandler<SearchEmployeeByIdQuery, SearchEmployeeByIdResponse>
    {
        private readonly IEmployeeRepository _repository;


        public SearchEmployeeByIdQueryHandler(IEmployeeRepository repository) =>
            _repository = repository;


        public SearchEmployeeByIdResponse Handle(SearchEmployeeByIdQuery query)
        {
            if (query is null)
                throw new InvalidEmployeeServiceException("Identificador de empleado inválido.");
            var result = _repository.SearchById<SearchEmployeeByIdResponse>(query.Id);
            if (result is null)
                throw new InvalidEmployeeServiceException("El empleado solicitado no existe.");
            return result;
        }


    }
}
