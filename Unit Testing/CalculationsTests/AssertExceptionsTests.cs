using System;

namespace CalculationsTests
{
    public class AssertExceptionsTests
    {
        [Fact]
        public void ThrowException_GivenNoArguments_ArgumentExceptionMessage()
        {
            var assertExceptions = new AssertExceptions();
            var exception = Record.Exception(() => assertExceptions.ThrowException(""));
            Assert.Equal("Hello Args Exception.", exception.Message);
        }
    }
}
