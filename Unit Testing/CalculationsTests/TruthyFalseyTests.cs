using System;

namespace CalculationsTests
{
    public class TruthyFalseyTests
    {
        [Fact]
        public void IsTruthy_GivenPositiveNumber_ReturnsTrue()
        {
            var truthyFalsey = new TruthyFalsey();
            var result = truthyFalsey.IsTruthy(1);
            Assert.True(result);
        }

        [Fact]
        public void IsTruthy_GivenNegativeNumber_ReturnsFalse()
        {
            var truthyFalsey = new TruthyFalsey();
            var result = truthyFalsey.IsTruthy(-1);
            Assert.False(result);
        }
    }
}
