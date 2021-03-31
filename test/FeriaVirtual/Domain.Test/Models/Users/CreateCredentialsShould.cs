using Domain.Test.Models.Users.ObjectMother;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.SeedWork.Validations;
using Xunit;

namespace Domain.Test.Models.Users
{
    public class CreateCredentialsShould
    {

        [Fact]
        public void CreateAValidCredentialObject()
        {
            var mockCredential = CreateCredentialMother.GetAValidCredential();
            Assert.NotNull(mockCredential);
        }


        [Theory]
        [InlineData("")]
        [InlineData("ana")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void ThrowBusinessRuleValidationException_IfUsernameHaveAInvalidValues
            (string usernameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => CreateCredentialMother.GetCredentialWithInvalidUsernameValues(usernameValue)
                );
        }


        [Theory]
        [InlineData("")]
        [InlineData("asdfgqw")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        [InlineData("password1234")]
        public void ThrowBusinessRuleValidationException_IfPasswordHaveAInvalidValues
            (string passwordValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => CreateCredentialMother.GetCredentialWithInvalidPasswordValues(passwordValue)
                );
        }


        [Theory]
        [InlineData("")]
        [InlineData("email.domain.com")]
        public void ThrowBusinessRuleValidationException_IfEmailHaveAInvalidValues
            (string emailValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => CreateCredentialMother.GetCredentialWithInvalidEmailValues(emailValue)
                );
        }


    }
}
