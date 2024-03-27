using System.IO;
using Xunit.Abstractions;

namespace CalculationsTests
{
    public class CalculatorTests : IClassFixture<CalculatorFixture>
    {
        //Inject the CalculatorFixture into the constructor
        private readonly CalculatorFixture _calculatorFixture;
        //Inject ITestOutputHelper into the constructor
        private readonly ITestOutputHelper _testOutputHelper;
        //Demonstrate the use of objects that require cleanup
        private readonly MemoryStream mMemoryStream;
        public CalculatorTests(CalculatorFixture calculatorFixture, ITestOutputHelper testOutputHelper)
        {
            _calculatorFixture = calculatorFixture;
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("CalculatorTests constructor");
            mMemoryStream = new MemoryStream(); //Streams need to be cleaned-up. 
        }

        [Fact]
        [Trait("Category", "Calculator")]
        public void Add_TwoIntegers_SumOfTwoIntegers()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        [Trait("Category", "Calculator")]
        public void Add_TwoDoubles_SumOfTwoDoubles()
        {
            var calculator = new Calculator();
            var result = calculator.AddDouble(1.2, 3.5);
            Assert.Equal(4.7, result);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_DoesNotIncludeZero_True()
        {
            _testOutputHelper.WriteLine("FiboNumbers_DoesNotIncludeZero_True Test Starting {0}", DateTime.Now);
            var result = _calculatorFixture.calc.FiboNumbers;
            Assert.All(result, item => Assert.NotEqual(0, item));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_CheckForThirteen_ReturnsTrue()
        {
            _testOutputHelper.WriteLine("FiboNumbers_CheckForThirteen_ReturnsTrue Test Starting {0}", DateTime.Now);
            var result = _calculatorFixture.calc.FiboNumbers;
            Assert.Contains(13, result);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection_CheckForFiboCollection_ReturnsTrue()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            var result = new Calculator().FiboNumbers;
            Assert.Equal(expectedCollection, result);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_ContainsNineItems_True()
        {
            var result = _calculatorFixture.calc.FiboNumbers;
            Assert.Equal(9, result.Count);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_IsOddCollections_ReturnsFalse()
        {
            //Check if all numbers in the Fibonacci sequence are odd
            var result = _calculatorFixture.calc.FiboNumbers;
            List<bool> allBoolItems = new List<bool> ();
            foreach (var item in result)
            {
                allBoolItems.Add(_calculatorFixture.calc.IsOdd(item));
            }
            //Check if list contains any false
            Assert.Contains(false, allBoolItems);
        }

        [Fact]
        [Trait("Category", "OddEven")]
        public void IsOdd_GivenIntegerIsOdd_ReturnsTrue()
        {
            //Check if the given number is odd
            var result = _calculatorFixture.calc.IsOdd(1);
            Assert.True(result);
        }

        [Fact]
        [Trait("Category", "OddEven")]
        public void IsOdd_GivenIntegerIsEven_ReturnsFalse()
        {
            //Check if the given number is odd
            var result = _calculatorFixture.calc.IsOdd(2);
            Assert.False(result);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [Trait("Category", "OddEven")]
        public void IsOdd_testOddAndEvenNumbers_InlineData(int number, bool expected)
        {
            //Check if the given number is odd
            var result = _calculatorFixture.calc.IsOdd(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        [Trait("Category", "OddEven")]
        public void IsOdd_testOddAndEvenNumbers_MemberData(int number, bool expected)
        {
            //Check if the given number is odd
            var result = _calculatorFixture.calc.IsOdd(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
        [Trait("Category", "OddEven")]
        public void IsOdd_testOddAndEvenNumbers_ExternalMemberData(int number, bool expected)
        {
            //Check if the given number is odd
            var result = _calculatorFixture.calc.IsOdd(number);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [IsOddOrEvenDataAttribute]
        [Trait("Category", "OddEven")]
        public void IsOdd_testOddAndEvenNumbers_ExternalMemberDataWithOwnAttribute(int number, bool expected)
        {
            //Check if the given number is odd
            var result = _calculatorFixture.calc.IsOdd(number);
            Assert.Equal(expected, result);
        }
    }

    public class CalculatorFixture: IDisposable
    {
        //Demonstrate the use of objects that require cleanup
        private readonly MemoryStream mMemoryStream;
        public CalculatorFixture()
        {
            //Streams will need to be cleaned-up.
            mMemoryStream = new MemoryStream();
        }
        public Calculator calc => new Calculator();

        public void Dispose()
        {
            //Clean up code
            mMemoryStream.Close();
        }
    }
}