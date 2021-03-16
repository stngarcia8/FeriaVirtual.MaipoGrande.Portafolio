using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Application.Users.Services;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Events;
using Moq;
using Xunit;

namespace FeriaVirtual.Application.Test.Users
{
    public class UserServiceTest
    {

        [Fact]
        public void GivenACreationUser_WhenUserDataIsNull_ThenShouldThrownInvalidUserServiceException()
        {
            // arrange
            var mockRepository = new Mock<IUserRepository>().Object;
            var mockEventPublisher = new Mock<IEventPublisher>().Object;
            var userService = new CreateUserService(mockRepository, mockEventPublisher);
            // act and assert
            Assert.Throws<InvalidUserServiceException>(
                () => userService.Create(null)
                );
        }

        [Fact]
        public void GivenAUpdateUser_WhenUserDataIsNull_ThenShouldThrownInvalidUserServiceException()
        {
            // arrange
            var mockRepository = new Mock<IUserRepository>().Object;
            var mockEventPublisher = new Mock<IEventPublisher>().Object;
            var userService = new UpdateUserService(mockRepository, mockEventPublisher);
            // act and assert
            Assert.Throws<InvalidUserServiceException>(
                () => userService.Update(null)
                );
        }

        [Fact]
        public void GivenAEnableUser_WhenUserDataIsNull_ThenShouldThrownInvalidUserServiceException()
        {
            // arrange
            var mockRepository = new Mock<IUserRepository>().Object;
            var mockEventPublisher = new Mock<IEventPublisher>().Object;
            var userService = new EnableOrDisableUserService(mockRepository, mockEventPublisher);
            // act and assert
            Assert.Throws<InvalidUserServiceException>(
                () => userService.EnableUser(null)
                );
        }

        [Fact]
        public void GivenADisableUser_WhenUserDataIsNull_ThenShouldThrownInvalidUserServiceException()
        {
            // arrange
            var mockRepository = new Mock<IUserRepository>().Object;
            var mockEventPublisher = new Mock<IEventPublisher>().Object;
            var userService = new EnableOrDisableUserService(mockRepository, mockEventPublisher);
            // act and assert
            Assert.Throws<InvalidUserServiceException>(
                () => userService.DisableUser(null)
                );
        }


    }
}
