using System;
namespace CalculationsTests
{
    [Collection("Customer")]
    public class CustomerTests
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void Name_GivenCustomer_ReturnsNotEmptyOrNullName()
        {
            var customer = _customerFixture.Customer;
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void Age_GivenCustomer_ReturnsAgeInRange()
        {
            var customer = _customerFixture.Customer;
            //Is customer age between 25 and 40?
            Assert.InRange<int>(customer.Age, 25, 40);
        }

        [Fact]
        public void CustomerType_GivenOrderCountAboveHundred_ReturnsLoyalCustomerType()
        {
            var customerUpgradeConditions = new CustomerUpradeConditions();
            var customer = customerUpgradeConditions.IsLoyalCustomer(101);
            Assert.IsType<LoyalCustomer>(customer);
        }

        public void CustomerType_GivenOrderCountBelowHundred_ReturnsNormalCustomerType()
        {
            var customerUpgradeConditions = new CustomerUpradeConditions();
            var customer = customerUpgradeConditions.IsLoyalCustomer(99);
            Assert.IsType<LoyalCustomer>(customer);
        }
    }
}