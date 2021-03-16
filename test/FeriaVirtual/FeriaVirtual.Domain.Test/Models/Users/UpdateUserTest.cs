using System;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.SeedWork.Validations;
using Xunit;

namespace FeriaVirtual.Domain.Test.Models.Users
{
    public class UpdateUserTest
    {
        Guid id = Guid.NewGuid();
        const string firstname = "Firstname";
        const string lastname = "Lastname";
        const string dni = "12345678-9";
        const int profileid = 1;

        [Fact]
        public void GivenAUserUpdate_WhenAllCorrectParameters_ThenUserIsNotNull()
        {
            // Arrange
            User mockUser = new User(id, firstname, lastname, dni, profileid);
            // Act and assert
            Assert.NotNull(mockUser);
        }

        [Fact]
        public void GivenAUserUpdate_WhenUseridHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException()
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(Guid.Empty, firstname, lastname, dni, profileid)
                );
        }

        [Theory]
        [InlineData("")]
        [InlineData("an")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void GivenAUserUpdate_WhenFirstnameHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string firstnameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(id, firstnameValue, lastname, dni, profileid)
                );
        }

        [Theory]
        [InlineData("")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void GivenAUserUpdate_WhenLastnameHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string lastnameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(id, firstname, lastnameValue, dni, profileid)
                );
        }

        [Theory]
        [InlineData("")]
        [InlineData("12345678-")]
        [InlineData("1234567890123456789-9")]
        public void GivenAUserUpdate_WhenDniHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (string dniValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(id, firstname, lastname, dniValue, profileid)
                );
        }

        [Theory]
        [InlineData(0)]
        [InlineData(7)]
        public void GivenAUserUpdate_WhenProfileidHasInvalidValues_ThenItShouldThrowBusinessRuleValidationException
            (int profileValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => new User(id, firstname, lastname, dni, profileValue)
                );
        }

        [Fact]
        public void GivenAUserUpdate_WhenRecreateValidCredentials_CredentialIsNotNull()
        {
            // Arrange
            User mockUser = new User(id, firstname, lastname, dni, profileid);
            // Act
            mockUser.GenerateCredentials(Guid.NewGuid(), "Username", "@Password.1234@", "email@dominio.com", 1);
            // assert
            Assert.NotNull(mockUser.GetCredential);
        }

    }
}
