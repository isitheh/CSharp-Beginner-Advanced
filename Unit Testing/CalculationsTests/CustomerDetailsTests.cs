using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsTests
{
    [Collection("Customer")]
    public class CustomerDetailsTests
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerDetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void GetCustomerFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = _customerFixture.Customer;
            var fullName = customer.GetCustomerFullName("John", "Doe");
            Assert.Equal("John Doe", fullName);
        }
    }
}
