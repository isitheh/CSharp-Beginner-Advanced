// See https://aka.ms/new-console-template for more information

using C_Part2.ClassIntro;
using C_Part2.Composition;
using C_Part2.DbConExercise;
using C_Part2.DemoEncapsulation;
using C_Part2.Exercises;
using C_Part2.Extensibility;
using C_Part2.Inheritance;
using C_Part2.MethodsParams;
using C_Part2.Polymorphism;
using C_Part2.WorkflowEngineExercise;

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
    ExerciseStopWatch();
    ExerciseStackOverflowPost();
    UsingCasting();
    UsingStackDesign();
    UsingPolymorphism();
    ExercisePolymorphism();
    UsingInterfaces();
    UsingWorkflowEngine();
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
    catch (Exception)
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

    var buyer = new Buyer
    {
        Id = 1,
        Name = "Raketi"
    };
    buyer.Promote();
    string regNum = "AB 12 FG - GP";
    var car = new Car(regNum);

    Circle circle = new Circle();
    //Convert an object reference circle to its base type reference shape.
    Shape shape = circle; //Only limited members are available to shape ref.

    circle.Width = 200;
    shape.Width = 100;
    Console.WriteLine("The above modify the same reference in memory - circle.Width = " + circle.Width);
    
    //First check if object is class before casting to class.
    if (shape is Circle)
    {
        Circle anotherCircle = (Circle) shape;
    }
    
}

void UsingComposition()
{
    var dbMigrator = new DbMigrator(new Logger());
    var logger = new Logger();
    var installer = new Installer(logger);

    dbMigrator.Migrate();
    installer.Install();

    var duck = new Duck(new Animal(), new Walkable(), new Swimmable());
    duck.TheDuckCan();

    var goldFish = new GoldFish(new Animal(), new Swimmable());
    goldFish.TheFishCan();

    var person = new PersonAnimal(new Animal(), new Walkable());
    person.ThePersonCan();

    var dogAnimal = new DogAnimal(new Animal(), new Walkable());
    dogAnimal.TheDogCan();
}

/*
   Design a Stopwatch:
   Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
   provide two methods: Start and Stop. We call the start method first, and the stop method next.
   Then we ask the stopwatch about the duration between start and stop. Duration should be a
   value in TimeSpan. Display the duration on the console.
 */
void ExerciseStopWatch()
{
    var stopWatch = new StopWatch();
    //First Run
    stopWatch.StartStopWatch();
    int oneSecond = 1000;
    Thread.Sleep(oneSecond);
    stopWatch.StopStopWatch();
    stopWatch.CalculateElapsedTime();

    //Second Run
    stopWatch.StartStopWatch();
    int twoSecond = 2000;
    Thread.Sleep(twoSecond);
    stopWatch.StopStopWatch();
    stopWatch.CalculateElapsedTime();

    //Third Run
    stopWatch.StartStopWatch();
    int threeSecond = 3000;
    Thread.Sleep(threeSecond);
    stopWatch.StopStopWatch();
    stopWatch.CalculateElapsedTime();
}

/*
   Design a StackOverflow Post:
   Design a class called Post. This class models a StackOverflow post. It should have properties
   for title, description and the date/time it was created. We should be able to up-vote or down-vote
   a post. We should also be able to see the current vote value. In the main method, create a post,
   up-vote and down-vote it a few times and then display the current vote value.
 */
void ExerciseStackOverflowPost()
{
    var stackOverflowPost = new StackOverflowPost()
    {
        Title = "C++ compiler not found, Windows 98.",
        Description = "C++ Compiler installed in the Windows Machine but not recognized on the command line.",
        TimeCreated = DateTime.Now,
    };
    Console.WriteLine("Post Title {0}", stackOverflowPost.Title);
    Console.WriteLine("Post Description {0}", stackOverflowPost.Description);
    Console.WriteLine("Post TimeCreated {0}", stackOverflowPost.TimeCreated);

    stackOverflowPost.UpVotePost();
    stackOverflowPost.DownVotePost();
    stackOverflowPost.UpVotePost();
    stackOverflowPost.UpVotePost();

    Console.WriteLine("Post Votes {0}", stackOverflowPost.GetPostVotes());
}

void UsingCasting()
{
    /*
     * The object shape is of type Shape at compile time but type Circle at runtime.
     */
    Shape shape = new Circle();
    Circle circle = (Circle)shape;  //Downcast
    var boxing = new BoxUnBox();
    boxing.BusyBoxing();
}

void UsingStackDesign()
{
    var stack = new StackDesign();
    stack.Push(1);
    stack.Push(2);
    stack.Push(3);
    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Pop());
    stack.Clear();
}

void UsingPolymorphism()
{
    var shapes = new List<ShapeClass>
    {
        new CircleClass(),
        new Rectangle(),
        new ImageClass(),
        new Triangle()
    };
    var canvas = new Canvas();
    canvas.DrawShapes(shapes);
}

void ExercisePolymorphism()
{
    var conOracle = new OracleConnection("OracleConnectionString");
    var makeCommandOracle = new DbCommand(conOracle, conOracle.ConnectionString);
    makeCommandOracle.Execute();
    Console.WriteLine("================ Break ================");
    var conSql = new SqlConnection("SqlConnectionString");
    var makeCommandSql = new DbCommand(conSql, conSql.ConnectionString);
    makeCommandSql.Execute();
}

void UsingInterfaces()
{
    //Place a log text file in the Downloads folder.
    var dbMigrator = new DbMigratorClass(new FileLogger("C:\\Users\\gamas1\\Downloads\\log.txt"));
    dbMigrator.Migrate();
}

void UsingWorkflowEngine()
{
    var workFlowRunner = new WorkflowEngine(new WfACtivity());
    workFlowRunner.Run();
}