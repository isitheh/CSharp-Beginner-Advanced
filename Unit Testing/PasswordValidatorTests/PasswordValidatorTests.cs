namespace PasswordValidatorTests
{
    public class PasswordValidatorTests
    {
        [Fact]
        public void ValidatePassword_GreaterThan8Characters_ReturnsTrue()
        {
            var passwordValidator = new PasswordValidator();
            var password = "1234567F";
            var result = passwordValidator.ValidatePassword(password);
            Assert.True(result);
        }
        [Fact]
        public void ValidatePassword_LessThan8Characters_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();
            var password = "1234567";
            var result = passwordValidator.ValidatePassword(password);
            Assert.False(result);
        }
        [Fact]
        public void ValidatePassword_ContainsNoUpperCase_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();
            var password = "aaaaaaaaaaa";
            var result = passwordValidator.ValidatePassword(password);
            Assert.False(result);
        }
        [Fact]
        public void ValidatePassword_ContainsUpperCase_ReturnsTrue()
        {
            var passwordValidator = new PasswordValidator();
            var password = "Aaaaaaaaaaa";
            var result = passwordValidator.ValidatePassword(password);
            Assert.True(result);
        }  
    }
}