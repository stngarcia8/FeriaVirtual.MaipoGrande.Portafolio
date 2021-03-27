using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Application.Users.Queries.Signin;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using Moq;
using Xunit;

namespace Application.Test.Users
{
    public class UserQueryHandlersShould
    {
        private readonly Mock<ISessionRepository> _repository;


        public UserQueryHandlersShould() =>
            _repository = new Mock<ISessionRepository>();


        [Fact]
        public void InvalidSignin()
        {
            var signinQueryMother = SigninMother.GetValidSigninQuery();
            _repository
                .Setup(x => x.SignIn<UserSigninResponse>(signinQueryMother.Username, signinQueryMother.Password))
                .Verifiable();
            var _handler = new UserSigninQueryHandler(_repository.Object);
            Assert.Throws<InvalidUserSigninServiceException>(
                () => _handler.Handle(signinQueryMother)
                );
        }


    }
}
