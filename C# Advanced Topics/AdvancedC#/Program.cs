// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Runtime.InteropServices.JavaScript;
using AdvancedC_.Delegates;
using AdvancedC_.Events;
using AdvancedC_.HandlingExceptions;
using AdvancedC_.LambdaFunc;
using static System.Reflection.Metadata.BlobBuilder;

Console.WriteLine("Hello, Advanced C# World!");
{
    UsingGenerics();
    UsingDelegates();
    UsingLambdaFunctions();
    UsingEventsAndDelegates();
    UsingMethodExtensions();
    UsingLinqExtensionMethods();
    UsingLinqQueryOperators();
    UsingNullable();
    UsingDynamicTypes();
    HandlingExceptions();
}

void UsingGenerics()
{
    Console.WriteLine("============ Topic: Generics ============");
    var numbers = new GenericList<int>();
    numbers.Add(10);

    var books = new GenericList<Book>();
    var dictionary = new GenericDictionary<string, Book>();

    var utility = new Utilities<int>();
    Console.WriteLine("Return: " + utility.Max(10, 5));
    Console.WriteLine("Return: " + utility.Maximum(5, 52));

    var number = new AdvancedC_.Generics.Nullable<int>();
    Console.WriteLine("Has value ? " + number.HasValue);
    Console.WriteLine("Actual value is: " + number.GetValueOrDefault());

    var warrior = new WarriorBook
    {
        Name = "Thambukthu",
        itemNum = 420
    };
    var bookReader = new GenericClass<WarriorBook>(warrior);
    bookReader.AnotherGenericPrintable();
    bookReader.ForceGenericToReadBook();
    Console.WriteLine("=========================================");
    Console.WriteLine();
}

void UsingDelegates()
{
    Console.WriteLine("============ Topic: Delegates ===========");
    var path = "C:SomePathToPhoto";
    var filters = new PhotoFilters();
    var photoProcessor = new PhotoProcessor();
    PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
    filterHandler += filters.ApplyContrast;
    filterHandler += filters.Resize;
    filterHandler += RemoveRedEyeFilter;
    photoProcessor.Process(path, filterHandler);
    Console.WriteLine("=========================================");
    Console.WriteLine();
}

static void RemoveRedEyeFilter(Photo photo)
{
    Console.WriteLine("Remove red eye from photo.");
}

void UsingLambdaFunctions()
{
    Console.WriteLine(" ============ Topic: Lambda Expressions ============");
    var lambdaDemo = new LambdaFunc();
    const int num = 5;
    Console.WriteLine("The square value of num {0} is {1}.", num, lambdaDemo.Square(num));

    /*
     * Part 2: Using lambda function notation. 
     * Syntax: args => expression (args goes to expression)
     * Achieve the same thing as above using a delegate. The delegate will
     * replace a function with a pointer/reference to the same function
     * Scope of the lambda expression is all the args together with all the
     * items declared within the braces in which the lambda expression exists.
     */
    const int myNum = 4;
    Func<int, int> mySquare = (number => (number * number));
    Console.WriteLine("The square value of myNum {0} is {1}.", myNum, mySquare(myNum));

    /*
     * Part 3: Lambda expression with multiple arguments and scope
     *
     */
    const int factor = 5;
    const int aNum = 3;
    const int zNum = 4;
    Func<int, int, int> multiplyByFactor = (a, b) => (factor*(a+b));
    Console.WriteLine("Multiplying num ({0} + {1}) by {2} results in {3}.", aNum, zNum, factor, multiplyByFactor(aNum, zNum));

    var books = new BookRepository().GetBooks();
    /*
     * Predicate Method:
     * A delegate/lambda expression which takes in a single param and returns a bool
     * which indicates whether the given input parameter meets a specific criteria.
     * An example of a predicate below:
     */
    var cheapBooks = books.FindAll(book => (book.Price < 10));
    var expensiveBooks = books.FindAll(book => (book.Price >= 10));

    //Each book in books is checked for price and only books that are price < 10 are returned into a list.
    Console.WriteLine("Cheap Books: ");
    foreach (var book in cheapBooks)
    {
        Console.WriteLine(book.Title);
    }

    Console.WriteLine("Expensive Books: ");
    foreach (var book in expensiveBooks)
    {
        Console.WriteLine(book.Title);
    }

    Console.WriteLine("====================================================");
    Console.WriteLine();
}

void UsingEventsAndDelegates()
{
    Console.WriteLine("================== Topic: Events ===================");

    var video = new Video() { Title = "Video 1" };
    var videoEncoder = new VideoEncoder();          //Event Publisher
    var mailService = new MailService();            //Event Subscriber
    var messageService = new MessageService();      //Event Subscriber
    var pagerService = new PagerService();          //Event Subscriber

    //Register the MailService and MessageService to VideoEncoder
    videoEncoder.VideoEncodedEvent += mailService.OnVideoEncodedEvent;      //Not a call, but
    videoEncoder.VideoEncodedEvent += messageService.OnVideoEncodedEvent;   //is a reference/ 
    videoEncoder.VideoEncodedEvent += pagerService.OnVideoEncodedEvent;     //pointer to a method.

    videoEncoder.Encode(video);

    Console.WriteLine("====================================================");
    Console.WriteLine();
}

void UsingMethodExtensions()
{
    Console.WriteLine("============= Topic: Method Extensions =============");
    string blogPost = "This is a very long blog post with Lorem Ipsum which " +
                      "is simply dummy text of the printing and typesetting industry. " +
                      "Lorem Ipsum has been the industry's standard dummy text ever " +
                      "since the 1500s, when an unknown printer took a galley of type " +
                      "and scrambled it to make a type specimen book. It has survived not" +
                      " only five centuries, but also the leap into electronic typesetting," +
                      " remaining essentially unchanged. It was popularised in the 1960s " +
                      "with the release of Letraset sheets containing Lorem Ipsum passages," +
                      " and more recently with desktop publishing software like Aldus " +
                      "PageMaker including versions of Lorem Ipsum.";

    var shortenedPost = blogPost.Shorten(10);
    Console.WriteLine(shortenedPost);

    Console.WriteLine("====================================================");
    Console.WriteLine();
}
void UsingLinqExtensionMethods() 
{
    Console.WriteLine("=========== Topic: LINQ Extension Methods ==========");
    var books = new BookRepository().GetBooks();
    var cheapBooksAgain = books.Where(book => book.Price < 10);
    var expensiveBooksAgain = books.Where(book => book.Price >= 10);

    Console.WriteLine("More Cheap Books: ");
    foreach (var book in cheapBooksAgain)
    {
        Console.WriteLine(book.Title);
    }

    Console.WriteLine("More Expensive Books: ");
    foreach (var book in expensiveBooksAgain)
    {
        Console.WriteLine(book.Title);
    }

    /*
     * LINQ
     * - Ordeby() Method used for sorting.
     * - Converts a list to a selected type
     * Chain LINQ methods to Filter books by price and order them by their titles.
     */
    var cheapBooksOrdered = books
        .Where(book => book.Price < 10)
        .OrderBy(book => book.Title)
        .Select(book => book.Title);
    //After Select, book is only available as a string (Title)
    Console.WriteLine("LINQ Extension Method For Ordered Cheap Books: ");
    foreach (var book in cheapBooksOrdered)
    {
        Console.WriteLine(book);
    }

    Console.WriteLine("=== MORE == Topic: LINQ Extension Methods =========");
    //To return only a single object in the result
    var duckBook = books.Single(b => b.Title == "Duck Duck Goose");
    Console.WriteLine(duckBook.Title);

    //If two objects exist, select the first of its name as below.
    var gameBookFirst = books.First(b => (b.Title == "Red Light, Green Light"));
    Console.WriteLine(gameBookFirst.Title + gameBookFirst.Price);

    //The select the first of its name as below.
    var gameBookLast = books.Last(b => (b.Title == "Red Light, Green Light"));
    Console.WriteLine(gameBookLast.Title + gameBookLast.Price);

    //To skip a number (x) of items in a list and return the next (y) available items.
    var mBooks = books.Skip(2).Take(2);
    Console.WriteLine("LINQ Extension Statement Skipped 2 selected 2: ");
    foreach (var book in mBooks)
    {
        Console.WriteLine(book.Title);
    }

    //Count the number of books
    Console.WriteLine("Number of books: " + books.Count);

    //Using the Max attribute. For example, return the book with the highest price.
    var mostExpBookPrice = books.Max(b => b.Price);
    Console.WriteLine("The most expensive book: " + mostExpBookPrice);

    //Using the Min attribute. For example, return the book with the lowest price.
    var leastExpBookPrice = books.Min(b => b.Price);
    Console.WriteLine("The least expensive book: " + leastExpBookPrice);

    //Using the Sum attribute. For example, return the total price for all books.
    var totalBooksPrice = books.Sum(b => b.Price);
    Console.WriteLine("The total book price: " + totalBooksPrice);

    //Using the Average attribute. For example, return the average price for all books.
    var averageBookPrice = books.Average(b => b.Price);
    Console.WriteLine("The average book price: " + averageBookPrice);

    Console.WriteLine("====================================================");
    Console.WriteLine();
}

void UsingLinqQueryOperators()
{
    Console.WriteLine("========== Topic: LINQ Query Statements ===========");
    /*
     * LINQ:
     * We write the same LINQ chain methods using Query operators.
     * See resemblance to SQL Query Statements.
     */
    var books = new BookRepository().GetBooks();
    var cheaperBooks =
        from b in books
        where b.Price < 10
        orderby b.Title
        select b.Title;
    Console.WriteLine("LINQ Query Statement For Ordered Cheap Books: ");
    foreach (var book in cheaperBooks)
    {
        Console.WriteLine(book);
    }
    Console.WriteLine("====================================================");
    Console.WriteLine();
}

void UsingNullable()
{
    Console.WriteLine("================= Topic: Nullable ==================");
    /*
     * The type DateTime var cannot be assigned to a null.
     * DateTime date = null (Invalid - compile error)
     * Introducing the question mark allows the type var to be nullable.
     */
    DateTime? date = new DateTime(2014, 1, 1);
    if (date != null)
    {
        Console.WriteLine("Value {0}.", date.Value);
    }
    Console.WriteLine("HasValue {0}.", date.HasValue);
    Console.WriteLine("GetValueOrDefault {0}.", date.GetValueOrDefault());

    //DateTime newDate = date; //Also a compile error, what if date is null?
    //This below will work since a default value has been defined for DateTime.
    DateTime newDate = date.GetValueOrDefault();
    Console.WriteLine("New Date from Nullable Date: " + newDate);

    //But see below, a nullable can be equated (on left) to a normal DateTime item.
    DateTime date2 = newDate;
    Console.WriteLine("No casting required: " + date2);

    //Null Coalescing Operator vs the Ternary Operator
    DateTime date4 = date ?? DateTime.Today;
    //Is similar to/the same as
    date4 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

    Console.WriteLine("====================================================");
    Console.WriteLine();
}

void UsingDynamicTypes()
{
    Console.WriteLine("================= Topic: Dynamic ==================");
    dynamic dynamicVar = "Test";
    Console.WriteLine("1.0 Dynamic Variable value: {0} ", dynamicVar);
    //The line below fails at runtime (Not at compile time).
    //Coz it is a dynamic typed variable. Which is string at this line.
    //dynamicVar++;     
    dynamicVar = 10;
    Console.WriteLine("2.0 Dynamic Variable value: {0} ", dynamicVar);
    //The line below passes at runtime.
    //Coz it is a dynamic typed variable. Which is int at this line.
    dynamicVar++;
    Console.WriteLine("3.0 Dynamic Variable value: {0} ", dynamicVar);
    Console.WriteLine("===================================================");
    Console.WriteLine();
}

void HandlingExceptions()
{
    Console.WriteLine("============ Topic: HandlingExceptions ============");
    DemonstratingTryCatch();
    DemonstratingFinally();
    DemonstratingUsingKeyword();
    DemonstratingCustomException();
    Console.WriteLine("===================================================");
    Console.WriteLine();
}

void DemonstratingTryCatch()
{
    try
    {
        var calculation = new Calculator();
        calculation.Divide(5, 0);
    }
    catch (Exception e)
    {
        Console.WriteLine("1.0 Sorry. An unexpected error occured.");
    }
}

void DemonstratingFinally()
{
    StreamReader streamReader = null;
    //Can add a '?' to make this nullable.
    //StreamReader ? streamReader = null;
    try
    {
        streamReader = new StreamReader(@"C:\file.zip");
        var content = streamReader.ReadToEnd();
    }
    catch (Exception e)
    {
        Console.WriteLine("2.0 Sorry. An unexpected error occured.");
    }
    finally
    {
        /*
         * finally:
         * Executes when the try/catch block exits. For any/all conditions.
         * The finally bock will always be executed.
         * Example:
         * Very important to ensure that stream is closed
         * no matter the outcome of the try catch.
         */
        if (streamReader != null)
        {
            streamReader.Dispose();
        }
    }
}

void DemonstratingUsingKeyword()
{
    /*
     * Tip:
     * To avoid having to call the finally block manually, can
     * instead implement the 'using' keyword inside the try catch.
     * This will implement the finally block under the hood.
     */
    try
    {
        using (var streamReader = new StreamReader(@"C:\file.zip"))
        {
            var content = streamReader.ReadToEnd();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("3.0 Sorry. An unexpected error occured.");
    }
}

void DemonstratingCustomException()
{
    try
    {
        var api = new YouTubeApi();
        api.GetYouTubeVideos("ShowBizz");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
