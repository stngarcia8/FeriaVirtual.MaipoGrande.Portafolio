using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.SeedWork.Validations;
using Xunit;

namespace Domain.Test.Models.Users
{
    public class CreateCredentialTest
    {
        const string username = "username";
        const string password = "@Password.1234@";
        const string email = "email@dominio.com";

        [Fact]
        public void GivenACredentialCreation_WhenAllCorrectParametrs_CredentialIsNotNull()
        {
            // Arrange
            var mockCredential = new Credential(username, password, email);
            // Act and assert
            Assert.NotNull(mockCredential);
        }

        [Theory]
        [InlineData("")]
        [InlineData("ana")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void GivenACredentialCreation_WhenUsernameHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string usernameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new Credential(usernameValue, password, email)
                );
        }

        [Theory]
        [InlineData("")]
        [InlineData("asdfgqw")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        [InlineData("password1234")]
        public void GivenACredentialCreation_WhenPasswordHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string passwordValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new Credential(username, passwordValue, email)
                );
        }

        [Theory]
        [InlineData("")]
        [InlineData("email.domain.com")]
        public void GivenACredentialCreation_WhenEmailHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string emailValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new Credential(username, password, emailValue)
                );
        }


    }
}
