using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using Moq;

namespace Application.Test.Users
{
    public abstract class UserModuleTestCase
    {
        protected readonly Mock<IUserRepository> _repository;


        public UserModuleTestCase() =>
            _repository = new Mock<IUserRepository>();

        protected void ShouldHaveSave(User user) =>

            _repository.Verify(x => x.Create(user), Times.AtLeastOnce());


    }
}
