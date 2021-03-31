using Domain.Test.Models.Users.ObjectMother;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.SeedWork.Validations;
using Xunit;

namespace Domain.Test.Models.Users
{
    public class UpdateUsersShould
    {

        [Fact]
        public void UpdateAValidUser()
        {
            User mockUser = UpdateUserMother.GetAValidUser();
            Assert.NotNull(mockUser);
        }


        [Fact]
        public void AValidUser_IfRecreateAValidUserCredential()
        {
            User mockUser = UpdateUserMother.GetAValidUser();
            Assert.NotNull(mockUser.GetCredential);
        }


        [Fact]
        public void ThrowBusinessRuleValidationException_IfUserIdHaveAInvalidValues()
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => UpdateUserMother.GetUserWithEmptyUserId()
                );
        }


        [Theory]
        [InlineData("")]
        [InlineData("an")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void ThrowBusinessRuleValidationException_IfFirstnameHaveInvalidValues
            (string firstnameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => UpdateUserMother.GetUserWithInvalidFirstname(firstnameValue)
                ); ;
        }


        [Theory]
        [InlineData("")]
        [InlineData("aaaaaaaaaabbbbbbbbbbccccccccccdddddddddeeeeeeeeeeff")]
        public void ThrowBusinessRuleValidationException_IfLastnameHaveInvalidValues
            (string lastnameValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => UpdateUserMother.GetUserWithInvalidLasttname(lastnameValue)
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
                () => UpdateUserMother.GetUserWithInvalidDni(dniValue)
                );
        }


        [Theory]
        [InlineData(0)]
        [InlineData(7)]
        public void ThrowBusinessRuleValidationException_IfProfileIdHaveInvalidValues
            (int profileValue)
        {
            Assert.Throws<BusinessRuleValidationException>(
                () => UpdateUserMother.GetUserWithInvalidProfileId(profileValue)
                );
        }


    }
}
