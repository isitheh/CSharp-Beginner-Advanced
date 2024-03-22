// See https://aka.ms/new-console-template for more information

using AdvancedC_.Delegates;
using AdvancedC_.Generics;

Console.WriteLine("Hello, Advanced C# World!");
{
    UsingGenerics();
    UsingDelegates();
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