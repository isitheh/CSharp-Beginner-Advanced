using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CalculationsTests
{
    public class IsOddOrEvenDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            string[] txtLines = File.ReadAllLines("IsOddOrEvenTestData.txt");
            return txtLines.Select(x =>
            {
                var data = x.Split(',');
                return new object[] { int.Parse(data[0]), bool.Parse(data[1]) };
            });
        }
    }
}
