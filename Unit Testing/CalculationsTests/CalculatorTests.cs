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
        public void Add_TwoIntegers_SumOfTwoIntegers()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
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