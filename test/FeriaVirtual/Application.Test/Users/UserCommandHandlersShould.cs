using FeriaVirtual.Application.Services.Users;
using FeriaVirtual.Application.Services.Users.Commands.ChangeStatus;
using FeriaVirtual.Application.Services.Users.Commands.Update;
using FeriaVirtual.Application.Services.Users.Create;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Events;
using Moq;
using System;
using Xunit;

namespace Application.Test.Users
{
    public class UserCommandHandlersShould
    {
        private readonly Mock<IUserRepository> _repository;
        private readonly Mock<IEventBus> _eventBus;


        public UserCommandHandlersShould()
        {
            _repository = new Mock<IUserRepository>();
            _eventBus = new Mock<IEventBus>();
        }


        [Fact]
        public void CreateAValidUser()
        {
            var userCommandMother = UserMother.GetValidCreateUserCommand();
            _repository.Setup(x => x.Create(It.IsAny<User>())).Verifiable();

            var _handler = new CreateUserCommandHandler(_repository.Object, _eventBus.Object);
            _handler.Handle(userCommandMother);

            _repository.Verify();
        }


        [Fact]
        public void ThrownInvalidUserServiceException_IfUserDataIsNull_WhenCreateAnUser()
        {
            _repository.Setup(x => x.Create(null)).Verifiable();

            var _handler = new CreateUserCommandHandler(_repository.Object, _eventBus.Object);

            Assert.Throws<InvalidUserServiceException>(
                () => _handler.Handle(null)
                );
        }


        [Fact]
        public void UpdateAValidUser()
        {
            var userCommandMother = UserMother.GetValidUpdateUserCommand();
            _repository.Setup(x => x.Update(It.IsAny<User>())).Verifiable();

            var _handler = new UpdateUserCommandHandler(_repository.Object, _eventBus.Object);
            _handler.Handle(userCommandMother);

            _repository.Verify();
        }


        [Fact]
        public void ThrownInvalidUserServiceException_IfUserDataIsNull_WhenUpdateAnUser()
        {
            _repository.Setup(x => x.Create(null)).Verifiable();

            var _handler = new UpdateUserCommandHandler(_repository.Object, _eventBus.Object);

            Assert.Throws<InvalidUserServiceException>(
                () => _handler.Handle(null)
                );
        }


        [Fact]
        public void EnableAValidUser()
        {
            var userCommandMother = UserMother.GetValidEnableUserStatusCommand();
            _repository.Setup(x => x.EnableUser(It.IsAny<Guid>())).Verifiable();

            var _handler = new ChangeUserStatusCommandHandler(_repository.Object, _eventBus.Object);
            _handler.Handle(userCommandMother);

            _repository.Verify();
        }


        [Fact]
        public void DisableAValidUser()
        {
            var userCommandMother = UserMother.GetValidDisableUserStatusCommand();
            _repository.Setup(x => x.DisableUser(It.IsAny<Guid>())).Verifiable();

            var _handler = new ChangeUserStatusCommandHandler(_repository.Object, _eventBus.Object);
            _handler.Handle(userCommandMother);

            _repository.Verify();
        }


        [Fact]
        public void ThrownInvalidUserServiceException_IfUserDataIsNull_WhenEnableAnUser()
        {
            _repository.Setup(x => x.EnableUser(It.IsAny<Guid>())).Verifiable();

            var _handler = new ChangeUserStatusCommandHandler(_repository.Object, _eventBus.Object);

            Assert.Throws<InvalidUserServiceException>(
                () => _handler.Handle(null)
                );
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(2)]
        public void ThrownInvalidUserServiceException_IfUserStatusIsInvalid_WhenDisableAnUser
            (int value)
        {
            var userCommandMother = UserMother.CreateUserStatusCommand(value);
            _repository.Setup(x => x.EnableUser(It.IsAny<Guid>())).Verifiable();

            var _handler = new ChangeUserStatusCommandHandler(_repository.Object, _eventBus.Object);

            Assert.Throws<InvalidUserServiceException>(
                () => _handler.Handle(null)
                );
        }


        [Fact]
        public void ThrownInvalidUserServiceException_IfUserDataIsNull_WhenDisableAnUser()
        {
            _repository.Setup(x => x.DisableUser(It.IsAny<Guid>())).Verifiable();

            var _handler = new ChangeUserStatusCommandHandler(_repository.Object, _eventBus.Object);

            Assert.Throws<InvalidUserServiceException>(
                () => _handler.Handle(null)
                );
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(2)]
        public void ThrownInvalidUserServiceException_IfUserStatusIsInvalid_WhenEnableAnUser
            (int value)
        {
            var userCommandMother = UserMother.CreateUserStatusCommand(value);
            _repository.Setup(x => x.DisableUser(It.IsAny<Guid>())).Verifiable();

            var _handler = new ChangeUserStatusCommandHandler(_repository.Object, _eventBus.Object);

            Assert.Throws<InvalidUserServiceException>(
                () => _handler.Handle(null)
                );
        }






    }
}
