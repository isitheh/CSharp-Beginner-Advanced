// See https://aka.ms/new-console-template for more information

using C_Part2.ClassIntro;
using C_Part2.DemoEncapsulation;
using C_Part2.Inheritance;
using C_Part2.MethodsParams;

Console.WriteLine("Hello, Intermediate C#!");
{
    UsingClasses();
    UseParams();
    UseRefOut();
    UsePoint();
    ReadOnlyFields();
    UseEncapsulation();
    UseIndexers();
    UsingInheritance();
    UsingComposition();
}



void UsingClasses()
{
    var person = Person.ParseFromName("Unesu", "Gama", 5, "Africa");
    person.Introduce();
    Console.WriteLine("{0} people have been introduced.", Person.peopleCount);

    var customer = new Customer(5, "Rodriguez");
    Console.WriteLine(" Id: " + customer.Id);
    Console.WriteLine(" Name: " + customer.Name);
    Console.WriteLine("Orders: " + customer.Orders);
}

void ReadOnlyFields()
{
    var customer = new Customer(1);
    customer.Orders.Add(new Order());
    customer.Orders.Add(new Order());
    Console.WriteLine("Customer Order Count = " + customer.Orders.Count);
    customer.Promote();
    Console.WriteLine("Customer Order Count = " + customer.Orders.Count);
}
void UseParams()
{
    //Method Signatures and Overloading
    var calculator = new Calculator();
    Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
    Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
    Console.WriteLine(calculator.Add(new int[] { 1, 2, 3 }));
    Console.WriteLine(calculator.Add(1, 2, 3));
}

void UseRefOut()
{
    //Using Ref and Out Modifiers/Keywords
    var usingRefOut = new UsingRefOut();
    var varIncrement = 12;
    usingRefOut.RefIncMethod(varIncrement);
    Console.WriteLine(varIncrement);
    usingRefOut.RefIncMethod(ref varIncrement);
    Console.WriteLine(varIncrement);
}

void UsePoint()
{
    var point = new Point(10, 20);
    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
    point.Move(15, 30);
    Console.WriteLine("New Point is at ({0}, {1})", point.X, point.Y);
    var newPoint = new Point(20, 40);
    try
    {
        point.Move(null);
        Console.WriteLine("Latest Point is at ({0}, {1})", point.X, point.Y);
    }
    catch (Exception e)
    {
        Console.WriteLine("Unexpected error occured: ");
        throw;
    }
}

void UseEncapsulation()
{
    var mChild = new Child();
    mChild.SetName("Unesu");
    mChild.SetBirthDate(new DateTime(2018, 11, 2));
    Console.WriteLine("The birthdate of my child named {0} is {1}.", mChild.GetName(), mChild.GetBirthdate());

    var mChildWithProps = new ChildWithProps(new DateTime(2012, 6, 3))
    {
        Name = "Thabi"
    };
    Console.WriteLine("The birthdate of my child named {0} is {1}.", mChildWithProps.Name, mChildWithProps.Birthdate);
    Console.WriteLine("The Age of my child named {0} is {1}.", mChildWithProps.Name, mChildWithProps.Age);
}

void UseIndexers()
{
    var cookie = new HttpCookie();
    cookie["name"] = "Royalty";
    Console.WriteLine("See result: " + cookie["name"]);
}

void UsingInheritance()
{
    var text = new Text
    {
        Width = 100
    };
    text.Copy();
}

void UsingComposition()
{
    var dbMigrator = new DbMigrator(new Logger());
    var logger = new Logger();
    var installer = new Installer(logger);

    dbMigrator.Migrate();
    installer.Install();
}