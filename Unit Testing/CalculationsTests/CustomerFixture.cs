using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsTests
{
    public class CustomerFixture
    {
        public CustomerFixture()
        {
            //Initialize the customer object
            Customer = new Customer();
        }
        public Customer Customer { get; private set; }
    }
}
