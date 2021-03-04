using FeriaVirtual.Application.Users.Dto;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Application.Users.Services
{
    public class EnableOrDisableUserService
        : IEnableOrDisableUserService
    {
        private readonly IUserRepository _repository;
        private readonly IEventPublisher _eventPublisher;


        public EnableOrDisableUserService(IUserRepository repository, IEventPublisher eventPublisher)
        {
            _repository = repository;
            _eventPublisher = eventPublisher;
        }

        public void EnableUser(EnableOrDisableUserDto userDto)
        {
            if (userDto is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            _repository.EnableUser(userDto.UserId);
        }

        public void DisableUser(EnableOrDisableUserDto userDto)
        {
            if (userDto is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            _repository.DisableUser(userDto.UserId);
        }



    }
}
