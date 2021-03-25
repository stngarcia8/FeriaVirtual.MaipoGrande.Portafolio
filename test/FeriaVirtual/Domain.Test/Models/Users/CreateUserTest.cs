using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.SeedWork.Validations;
using Xunit;

namespace Domain.Test.Models.Users
{
    public class CreateUserTest
    {
        const string firstname = "Firstname";
        const string lastname = "Lastname";
        const string dni = "12345678-9";
        const int profileid = 1;

        [Fact]
        public void GivenAUserCreation_WhenAllCorrectParameters_ThenUserIsNotNull()
        {
            // Arrange
            User mockUser = new(firstname, lastname, dni, profileid);
            // Act and assert
            Assert.NotNull(mockUser);
        }

        [Theory]
        [InlineData("")]
        [InlineData("an")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void GivenAUserCreation_WhenFirstnameHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string firstnameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(firstnameValue, lastname, dni, profileid)
                );
        }

        [Theory]
        [InlineData("")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void GivenAUserCreation_WhenLastnameHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string lastnameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(firstname, lastnameValue, dni, profileid)
                );
        }

        [Theory]
        [InlineData("")]
        [InlineData("12345678-")]
        [InlineData("1234567890123456789-9")]
        public void GivenAUserCreation_WhenDniHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string dniValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(firstname, lastname, dniValue, profileid)
                );
        }

        [Theory]
        [InlineData(0)]
        [InlineData(7)]
        public void GivenAUserCreation_WhenProfileIdHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (int profileidValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(firstname, lastname, dni, profileidValue)
                );
        }

        [Fact]
        public void GivenAUserCreation_WhenCreateValidCredentials_CredentialIsNotNull()
        {
            // Arrange
            User mockUser = new(firstname, lastname, dni, profileid);
            // Act
            mockUser.CreateCredentials("Username", "@Password.1234@", "email@dominio.com");
            // assert
            Assert.NotNull(mockUser.GetCredential);
        }


    }
}
