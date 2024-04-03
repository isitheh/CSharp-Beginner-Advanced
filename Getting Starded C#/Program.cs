// See https://aka.ms/new-console-template for more information
{
    WorkingWithStrings();
    WorkingWithIntegers();
    WorkingWithFloatAndDouble();
    WorkingWithBooleans();
    WorkingWithDateTime();
    CastingAndParsing();
    WorkingWithIfStatements();
    WorkingWithTernaryOperator();
    WorkingWithSwitchStatement();
    WorkingWithCollections();
}

void WorkingWithStrings()
{
    //Declare and assign a string with an escape
    string myString;
    myString = "Hello \"Dometrain\" World!";
    Console.WriteLine(myString);

    //Concatenate a string
    string firstName = "John";
    string lastName = "Doe";
    string fullName = firstName + " " + lastName;
    Console.WriteLine(fullName);

    //Read strings from the user via cmd - ReadLine()
    Console.WriteLine("Enter a string: ");
    /*string inputString = Console.ReadLine();
    if (inputString != null)
    {
        Console.WriteLine("String {0} is {1} characters long.", inputString, inputString.Length);
        //Can access individual characters in a string using an index
        Console.WriteLine("The first character is {0}", inputString[0]);
    }*/

    //Can declare a string as a verbatim string literal using the @ symbol
    string verbatimString = @"C:\Users\JohnDoe\Documents";
    Console.WriteLine("Verbatim String: " + verbatimString);

    //Can use string interpolation to embed expressions in a string
    string interpolatedString = $"My name is {firstName} {lastName}";
    Console.WriteLine("Interpolated String: " + interpolatedString);

    //Can use string formatting to format a string
    string formattedString = string.Format("My name is {0} {1}", firstName, lastName);
    Console.WriteLine("Formatted String: " + formattedString);

    //Can use single quotes to declare a char
    char myChar = 'A';
    Console.WriteLine("My char is: " + myChar);
}

void WorkingWithIntegers()
{
    //Declare and assign an integer
    int myInt = 5;
    Console.WriteLine("My integer is: " + myInt);

    //Can do some math with integers
    int sum = 5 + 10;
    Console.WriteLine("The sum of 5 + 10 is: " + sum);
    int difference = 5 - 10;
    Console.WriteLine("The difference of 5 - 10 is: " + difference);
    int product = 5 * 10;
    Console.WriteLine("The product of 5 * 10 is: " + product);
    int quotient = 5 / 10; 
    Console.WriteLine("The quotient of 5 / 10 is: " + quotient);
    //This will return only the integer part of the division. To get the decimal part, use double
    Console.WriteLine("Use Type Double Instead.");
    double quotientDouble = 5.0 / 10.0;
    Console.WriteLine("The quotient of 5.0 / 10.0 is: " + quotientDouble);
}

void WorkingWithFloatAndDouble()
{
    //Declare and assign a float
    float myFloat = 5.5f;
    Console.WriteLine("My float is: " + myFloat);
    //Declare and assign a double
    double myDouble = 5.5;
    Console.WriteLine("My double is: " + myDouble);
    //Can do some math with floats and doubles
    float sumFloat = 5.5f + 10.5f;
    Console.WriteLine("The sum of 5.5 + 10.5 is: " + sumFloat);
    double sumDouble = 5.5 + 10.5;
    Console.WriteLine("The sum of 5.5 + 10.5 is: " + sumDouble);
    float differenceFloat = 5.5f - 10.5f;
    Console.WriteLine("The difference of 5.5 - 10.5 is: " + differenceFloat);
    double differenceDouble = 5.5 - 10.5;
    Console.WriteLine("The difference of 5.5 - 10.5 is: " + differenceDouble);
    float productFloat = 5.5f * 10.5f;
    Console.WriteLine("The product of 5.5 * 10.5 is: " + productFloat);
    double productDouble = 5.5 * 10.5;
    Console.WriteLine("The product of 5.5 * 10.5 is: " + productDouble);
    float quotientFloat = 5.5f / 10.5f;
    Console.WriteLine("The quotient of 5.5 / 10.5 is: " + quotientFloat);
    double quotientDouble = 5.5 / 10.5;
    Console.WriteLine("The quotient of 5.5 / 10.5 is: " + quotientDouble);
}

void WorkingWithBooleans()
{
    //Declare and assign a boolean
    bool myBool = true;
    Console.WriteLine("My boolean is: " + myBool);
    //Can use boolean operators
    bool isTrue = true;
    bool isFalse = false;
    Console.WriteLine("Is True && Is False: " + (isTrue && isFalse));   //AND
    Console.WriteLine("Is True || Is False: " + (isTrue || isFalse));   //OR
    Console.WriteLine("Is !Is True: " + (!isTrue));     //Not operator
    Console.WriteLine("Is !Is False: " + (!isFalse));
    //Can use comparison operators
    int x = 5;
    int y = 10;
    Console.WriteLine("x = {0}. y = {1}.", x, y);
    Console.WriteLine("Is x == y: " + (x == y));
    Console.WriteLine("Is x != y: " + (x != y));    
    Console.WriteLine("Is x > y: " + (x > y));
    Console.WriteLine("Is x < y: " + (x < y));
    Console.WriteLine("Is x >= y: " + (x >= y));
    Console.WriteLine("Is x <= y: " + (x <= y));
}

void WorkingWithDateTime()
{
    //Declare and assign a DateTime
    DateTime myDateTime = DateTime.Now;
    Console.WriteLine("My DateTime is: " + myDateTime);
    //Can access individual components of a DateTime
    Console.WriteLine("Year: " + myDateTime.Year);
    Console.WriteLine("Month: " + myDateTime.Month);
    Console.WriteLine("Day: " + myDateTime.Day);
    Console.WriteLine("Hour: " + myDateTime.Hour);
    Console.WriteLine("Minute: " + myDateTime.Minute);
    Console.WriteLine("Second: " + myDateTime.Second);

    //Declare and assign DateOnly
    DateOnly myDateOnly = new DateOnly(2021, 10, 10);
    Console.WriteLine("My DateOnly is: " + myDateOnly);

    //Declare and assign TimeOnly
    TimeOnly myTimeOnly = new TimeOnly(10, 30, 0);
    Console.WriteLine("My TimeOnly is: " + myTimeOnly);

    //Can create a DateTime from a DateOnly and TimeOnly
    DateTime myDateTimeFromParts = new DateTime(myDateOnly, myTimeOnly);
    Console.WriteLine("My DateTime from parts is: " + myDateTimeFromParts);
}

void CastingAndParsing()
{ 
    //Implicit casting
    int myInt = 5;
    double myDouble = myInt;
    Console.WriteLine("My implicitly cast double is: " + myDouble);

    //Explicit casting
    double myDouble2 = 5.5;
    int myInt2 = (int)myDouble2;
    Console.WriteLine("My explicitly cast int is: " + myInt2);

    //Parsing
    string myString = "5";  //Must be parseable to an int. Cannot parse "five".
    int myInt3 = int.Parse(myString);
    Console.WriteLine("My parsed int is: " + myInt3);

    string myString2 = "5.5";   //Must be parseable to a double. Cannot parse "five point five".
    double myDouble3 = double.Parse(myString2);
    Console.WriteLine("My parsed double is: " + myDouble3);
}

void WorkingWithIfStatements()
{ 
    if(true)
    {
        Console.WriteLine("This will always print.");
    }

    if(false)
    {
        Console.WriteLine("This will never print.");
    }

    bool condition = false;  
    if(condition) 
    {
        Console.WriteLine("This will print if condition is true.");
    }
    else
    {
        Console.WriteLine("This will print if condition is false.");
    }

    int x = 5;
    int y = 10;
    if(x > y)   //Check the first condition
    {
        Console.WriteLine("x is greater than y.");
    }
    else if(x < y)  //Check the second condition
    {
        Console.WriteLine("x is less than y.");
    }
    else
    {
        Console.WriteLine("x is equal to y.");
    }

    int number = 3;
    if(number >= 1 && number <= 5)
    {
        Console.WriteLine("Number is between 1 and 5.");
    }
    else
    {
        Console.WriteLine("The number is not between 1 and 5");
    }

    if(number < 1 || number > 5)
    {
        Console.WriteLine("Number is not between 1 and 5.");
    }
    else
    {
        Console.WriteLine("Number is between 1 and 5.");
    }
}

void WorkingWithTernaryOperator()
{
    //Ternary operator Syntax: condition ? expression1 : expression2
    int x = 5;
    int y = 10;

    string result = x > y ? "x is greater than y." : "x is less than or equal to y.";
    Console.WriteLine(result);

    result = x == y ? "x is equal to y." : "x is not equal to y.";
    Console.WriteLine(result);
}

void WorkingWithSwitchStatement()
{
    /*
     * A Note: 
     *  break statement: is used to exit the switch statement. 
     *  If break is not used, the code will continue to execute the next case.
     *  return statement: is used to exit the method.
     */
    int dayOfWeek = 33;
    switch(dayOfWeek)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:     
            Console.WriteLine("Tuesday");
            return; // No dancing on tuesday.
        case 3: 
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
        case 7:
            Console.WriteLine("Its weekend");
            break;
        default:
            Console.WriteLine("Invalid day of the week.");
            break;
    }
    Console.WriteLine("Some dancing, unless its tuesday");

    string dayOfWeekString = "Thursday";
    string mRes = dayOfWeekString switch
    {
        "Monday" => "Its Monday",
        "Tuesday" => "Its Tuesday",
        "Wednesday" => "Its Wednesday",
        "Thursday" => "Its Thursday",
        "Friday" => "Its Friday",
        "Saturday" => "Its Saturday",
        "Sunday" => "Its Sunday",
        _ => "Invalid day of the week"
    };
} 

void WorkingWithCollections()
{
    workingWithArrays();
    WorkingWithLists();
    WorkingWithDictionaries();
}

void workingWithArrays()
{
    //Arrays are fixed size - must specify the size when declaring
    //Arrays are zero-based - first element is at index 0
    //Arrays can be multi-dimensional - 2D, 3D, etc.
    //Arrays are mutable - can change the elements
    //Declare and initialize an array of integers with a size of 5
    int[] myArray = new int[3];

    myArray[0] = 1;
    myArray[1] = 2;
    myArray[2] = 3;

    //Read the value at index 0 - This will return 1 - This doesn't remove the element out of the array.
    int firstElement = myArray[0];
    int secondElement = myArray[1];
    int thirdElement = myArray[2];
    //int fourthElement = myArray[3]; //This will throw an IndexOutOfRangeException

    //Declare and initialize an array of integers with a size of 3 - Using the collections initializer
    int[] numbersArray = new int[] { 1, 2, 3 };

    //Declare and initialize an array of integers with a size of 3 - Using curly braces
    int[] anotherArray = { 1, 2, 3 };

    //Declare and initialize an array of integers with a size of 3 - Using square braces
    int[] yetAnotherArray = [1, 2, 3];

    //The Length property of an array returns the number of elements in the array
    int arrayLength = myArray.Length;   //Returns 3
}

void WorkingWithLists() 
{
    //Lists are dynamic - can grow or shrink in size
    //Lists are zero-based - first element is at index 0
    //Lists are mutable - can change the elements
    //Can insert, remove, and find elements in a list
    //Can sort and search a list

    //Declare and initialize a list of strings
    List<string> myStringList = new List<string>();

    //Add elements to the list
    myStringList.Add("One");
    myStringList.Add("Two");
    myStringList.Add("Three");

    //Read the value at index 0 - This will return "One"
    string firstElement = myStringList[0];
    Console.WriteLine("1.0 ============ firstElement: " + firstElement);
    //Change an element in the list
    myStringList[0] = "Vue";
    firstElement = myStringList[0];
    Console.WriteLine("2.0 ============ firstElement: " + firstElement);

    //Declare and initialize a list of integers with a size of 3 - Using the collections initializer
    List<int> numbersList = new List<int>() { 1, 2, 3 };

    //The Count property of a list returns the number of elements in the list
    int listCount = myStringList.Count;   //Returns 3
    Console.WriteLine("Size of this List = " + listCount);

    //Insert an element at a specific index
    myStringList.Insert(1, "Two and a half");
    string secondElement = myStringList[1];
    Console.WriteLine("3.0 ========= secondElement: " + secondElement);

    //Remove an element at a specific index
    myStringList.RemoveAt(1);
    secondElement = myStringList[1];
    Console.WriteLine("4.0 ========= secondElement: " + secondElement);

    //Remove an element by value
    myStringList.Remove("Three");

    //Find the index of an element
    int index = myStringList.IndexOf("Two");
    Console.WriteLine("The index of a string 'Two' is {0}.", index);

    //Sort the list
    myStringList.Sort();
    firstElement = myStringList[0];
    Console.WriteLine("5.0 ============ firstElement: " + firstElement);

    //Get the count of elements in the list
    int count = myStringList.Count;
    Console.WriteLine("The count of elements in the list is {0}.", count);

    //Clear the list
    myStringList.Clear();

    //Get the count of elements in the list
    count = myStringList.Count;
    Console.WriteLine("The count of elements in the list is {0}.", count);
}

void WorkingWithDictionaries()
{
    //A dictionary is a collection of key-value pairs
    //Dictionaries are dynamic - can grow or shrink in size
    //Dictionaries are mutable - can change the elements
    //Can insert, remove, and find elements in a dictionary
    //Can sort and search a dictionary
    //Dictionary keys must be unique
    //Dictionary values can be duplicates
    //Dictionary keys are case-sensitive
    //Dictionary keys can be of any data type
    //Dictionary values can be of any data type
    //Dictionary keys can be of different data types
    //Dictionary values can be of different data types
    //Dictionary keys can be null
    Dictionary<string, int> wordNumber = new Dictionary<string, int>();
    Dictionary<string, string> wordMeaning = new Dictionary<string, string>();
    Dictionary<int, string> numberToWord = new Dictionary<int, string>();

    //Add elements to the dictionary
    wordNumber.Add("One", 1);
    wordNumber.Add("Two", 2);
    wordNumber.Add("Three", 3);

    wordMeaning.Add("One", "A number representing a single thing or unit.");
    wordMeaning.Add("Two", "A number representing a pair of things or units.");
    wordMeaning.Add("Three", "A number representing a group of three things or units.");

    numberToWord.Add(1, "One");
    numberToWord.Add(2, "Two");
    numberToWord.Add(3, "Three");

    //Read the value at a specific key
    int one = wordNumber["One"];
    Console.WriteLine("The value at the key 'One' is {0}.", one);

    //Set the value at a specific key
    wordNumber["One"] = 10;
    one = wordNumber["One"];
    Console.WriteLine("The value at the key 'One' is {0}.", one);

    //Check if a key exists in the dictionary
    bool containsKey = wordNumber.ContainsKey("One");
    Console.WriteLine("The dictionary contains the key 'One': {0}.", containsKey);

    //Check if a value exists in the dictionary
    bool containsValue = wordNumber.ContainsValue(10);

    //Declare and initialize a dictionary of strings and integers with a size of 3 - Using the collections initializer
    Dictionary<string, int> numbersDictionary = new Dictionary<string, int>() 
    { 
        { "One", 1 }, 
        { "Two", 2 }, 
        { "Three", 3 } 
    };

    //OR - Samething as above using square braces and keyword new.
    Dictionary<string, int> anotherDictionary = new()
    {
        ["One"] = 1,
        ["Two"] = 2,
        ["Three"] = 3
    };

    //The Count property of a dictionary returns the number of elements in the dictionary
    int dictionaryCount = wordNumber.Count;   //Returns 3
    Console.WriteLine("The count of elements in the dictionary is {0}.", dictionaryCount);

    //Remove an element by key  
    wordNumber.Remove("One");

    //Add a value that already exists in the dictionary
    wordNumber.Add("Two", 2);

}