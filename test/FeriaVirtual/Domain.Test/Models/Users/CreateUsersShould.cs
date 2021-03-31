using Domain.Test.Models.Users.ObjectMother;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.SeedWork.Validations;
using Xunit;

namespace Domain.Test.Models.Users
{
    public class CreateUsersShould
    {
        [Fact]
        public void CreateAValidUser()
        {
            User mockUser = CreateUserMother.GetAValidUser();
            Assert.NotNull(mockUser);
        }


        [Theory]
        [InlineData("")]
        [InlineData("an")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void ThrowBusinessRuleValidationException_IfFirstnameHaveInvalidValues
            (string firstnameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => CreateUserMother.GetUserWithInvalidFirstname(firstnameValue)
                );
        }


        [Theory]
        [InlineData("")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void ThrowBusinessRuleValidationException_IfLastnameHaveInvalidValues
            (string lastnameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => CreateUserMother.GetUserWithInvalidLasttname(lastnameValue)
                );
        }


        [Theory]
        [InlineData("")]
        [InlineData("12345678-")]
        [InlineData("1234567890123456789-9")]
        public void ThrowBusinessRuleValidationException_IfDniHaveInvalidValues
            (string dniValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => CreateUserMother.GetUserWithInvalidDni(dniValue)
                );
        }


        [Theory]
        [InlineData(0)]
        [InlineData(7)]
        public void ThrowBusinessRuleValidationException_IfProfileIdHaveInvalidValues
            (int profileidValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => CreateUserMother.GetUserWithInvalidProfileId(profileidValue)
                );
        }



    }
}
