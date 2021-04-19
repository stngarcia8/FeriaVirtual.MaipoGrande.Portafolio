using FeriaVirtual.Application.Services.Signin;
using FeriaVirtual.Application.Services.Signin.Queries;
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
                .Setup(x => x.SignIn<SigninResponse>(signinQueryMother.Username, signinQueryMother.Password))
                .Verifiable();
            var _handler = new SigninQueryHandler(_repository.Object);
            Assert.ThrowsAsync<InvalidSigninServiceException>(
                () => _handler.Handle(signinQueryMother)
                );
        }


    }
}
