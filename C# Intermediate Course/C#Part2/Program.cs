// See https://aka.ms/new-console-template for more information

using C_Part2.ClassIntro;

Console.WriteLine("Hello, Intermediate C#!");
{
    var person = Person.ParseFromName("Unesu", "Gama", 5, "Africa");
    person.Introduce();
    Console.WriteLine("{0} people have been introduced.", Person.peopleCount);

    var customer = new Customer(5, "Rodriguez");
    Console.WriteLine(" Id: " + customer.Id);
    Console.WriteLine(" Name: " + customer.Name);
    Console.WriteLine("Orders: " + customer.Orders);    
}