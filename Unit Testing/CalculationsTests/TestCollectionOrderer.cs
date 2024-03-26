using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace CalculationsTests
{
    public class TestCollectionOrderer : ITestCollectionOrderer
    {
        public TestCollectionOrderer() 
        { 
            
        }

        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            //Order the test collections by display name sequentially.
            return testCollections.OrderBy(x => x.DisplayName);
        }
    }
}
