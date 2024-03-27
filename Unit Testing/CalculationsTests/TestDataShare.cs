using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsTests
{
    public static class TestDataShare
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 10, false };
                yield return new object[] { 3, true };
                yield return new object[] { 2, false };
            }
        }

        public static IEnumerable<object[]> IsOddOrEvenExternalData
        {
            get
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
}
