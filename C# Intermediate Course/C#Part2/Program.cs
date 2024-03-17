﻿// See https://aka.ms/new-console-template for more information

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
    ExerciseStopWatch();
    ExerciseStackOverflowPost();
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