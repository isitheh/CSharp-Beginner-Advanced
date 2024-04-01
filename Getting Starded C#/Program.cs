// See https://aka.ms/new-console-template for more information
{
    WorkingWithStrings();
    WorkingWithIntegers();
    WorkingWithFloatAndDouble();
    WorkingWithBooleans();
    WorkingWithDateTime();
    CastingAndParsing();
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