namespace C_Part2.ClassIntro;

public class Customer()
{
    public int Id;
    public string Name;
    //Declare a list of objects, each of type order.
    //Orders are readonly.
    public readonly List<Order> Orders = new();

    public Customer(int id)
        : this()                //Always call the default constructor first before this custom constructor.
    {
        this.Id = id;
    }

    public Customer(int id, string name)
        : this(id)                //Always call the default constructor first before this custom constructor. 
    {
        this.Name = name;
    }

    public void Promote()
    {
        //This method will promote the customer to Gold Customer
    }
}