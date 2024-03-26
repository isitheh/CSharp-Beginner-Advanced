using System;

public class Customer
{
	public string Name => "John Doe";
	public int Age => 34;

    public string GetCustomerFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}

public class  LoyalCustomer : Customer
{
    public int Discount { get; set; }
	public LoyalCustomer()
	{
        Discount = 10;
    }
}

public class CustomerUpradeConditions
{
    public Customer IsLoyalCustomer(int orderCount)
    {
        if (orderCount < 100)
        {
            return new Customer();
        }
        else
        {
            return new LoyalCustomer();
        }
    }
}
