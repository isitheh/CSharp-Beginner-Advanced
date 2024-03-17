// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Learning_Basics_of_C_.Exercises;
using Learning_Basics_of_C_.Math;
using Learning_Basics_of_C_.Shipping;
using Learning_Basics_of_C_.Structures;
using static ConditionalsClass;

Console.WriteLine("Hello, World!");

/*
 * Concept: Overflow
 * The following block of code will not work as byte would overflow.
 * Byte max value is 255. 
 * Hence 255 + 1 results in overflow back to 0.
 * {
        byte num = 255;
        num = num + 1;
        Console.WriteLine(num);
    }
 * Using type short/int instead
 */
{
    int num = 255;
    num = num + 1;
    Console.WriteLine(num);
}

/*
 * Reminders: 
 * 1. In C#, cannot use a variable only declared. 
 *    Variable must first be assigned a value before being used.
 * 2. A variable of type float is initialized with a floating point value
 *    followed by an 'f'. Without the 'f' the variable gets treated as a double.
 * 3. A character is initialized with single quotation marks while a string 
 *    is initialized with using double quotation marks.
 * 4. Boolean variables can only be set to true/false keywords.
 * 5. Can simply declare a variable using keyword var and C# decides the type.
 * 6. By default, integral numbers are assigned to int if var is used.
 */
{
    byte number = 2;
    Console.WriteLine("Debug Trace: Var number = " + number);
    int count = 10;
    float totalPrice = 20.95f;
    char character = 'A';
    string firstName = "Babadoo";
    bool isWorking = true;
    var myNameIs = "SG Gama";

    Console.WriteLine("Debug Trace: Var count = " + count);
    Console.WriteLine("Debug Trace: Var totalPrice = " + totalPrice);
    Console.WriteLine("Debug Trace: Var character = " + character);
    Console.WriteLine("Debug Trace: Var firstName = " + firstName);
    Console.WriteLine("Debug Trace: Var isWorking = " + isWorking);
    Console.WriteLine("Debug Trace: Var myNameIs = " + myNameIs);
}

/*
 * Determine a range that can be stored in a type using format strings as args:
 * Arg 1: {0}
 * Arg 2: {1}
 * An Example of defining a constant value of Pi = 3.14 which is immutable.
 */
{
    const float Pi = 3.14f;
    Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);
    Console.WriteLine("{0}, {1}", float.MinValue, float.MaxValue);
    Console.WriteLine("The value of Pi: " + Pi);
}

/*
 * Type Conversion:
 * The conversion of byte to int works because byte is a smaller
 * type (1 byte) compared to an int (4 bytes). So a byte can fit
 * into an int. Compiler just prepends with zeros.
 */
{
    byte b = 1; //00000001
    int i = b;  //00000000 00000000 00000000 00000001
    Console.WriteLine("intType i = " + i);
}

/*
 * Type Conversion: (Error)
 * The conversion of type int into type byte will not work because
 * byte is less than int in size so this would lead to a potential data loss.
 * {
 *      int i = 300;
 *      byte b = i; //Does not work. Compilation error.
 * }
 * Casting:
 * Used if the programmer is sure that there would be no data loss implied.
 */
{
    int i = 1;
    byte b = (byte) i;
    Console.WriteLine("byteType b = " + b);

    int x = 1000;       //Larger than 255 (size of largest possible byte)
    byte z = (byte) x;  //Basically a representation of an 8 byte int (normally 32).
    /*
     * Returns 232 since 1000 cannot fit into a byte max 256 (0 included)
     * How its calculated: 232 = (1000 - 256 - 256 - 256)
     */
    Console.WriteLine("byteType z = " + z); //
}

/*
 * Type Conversion:
 * Some types are unable to be converted using casting.
 * An example is converting between strings and integrals.
 * In these cases, conversion methods need to be used.
 */
{
    var s = "1234";
    //int i = (int)s; Does not work
    /*
     * Convert class also has the following methods:
     * ToByte(), ToInt16(), ToInt32() etc.
     */
    int i = Convert.ToInt32(s);
    int j = int.Parse(s);
    Console.WriteLine("i = " + i);
    Console.WriteLine("j = " + j);

    try
    {
        var ss = "true";
        bool b = Convert.ToBoolean(ss);
        Console.WriteLine("b = " + b);
    }
    catch (Exception e)
    {
        //Prevents the application from crashing.
        Console.WriteLine("The number could not be converted to a byte" + e);
        throw;
    }
    
}

/*
 * Operators:
 * Arithmetic: Deals with operations performed on numbers.
 * Comparison: Is the boolean result of comparing operands.
 * Assignment: Assign operand on the right to the operand on the left.
 * Logical: Used in boolean operations, often used in conditional statements.
 * Bitwise: Often used in low level operations. Explanation later.
 */

{
    /*
     * Postfix increment example:
     * In the example below, a is first assigned to b then incremented.
     * So the value of b if printed will be the previous value of a.
     */
    int a = 1;
    int b = a++;
    Console.WriteLine("The value of a = " + a);
    Console.WriteLine("The value of b = " + b);
    Console.WriteLine("Add a and b: " + (a+b));

    /*
     * Prefix increment example:
     * In the example below, c is first incremented then assigned to d.
     * So the value of d and the value of c is both the final value of c;
     */
    int c = 1;
    int d = ++c;
    Console.WriteLine("The value of c = " + c);
    Console.WriteLine("The value of d = " + d);

    /*
     * Division:
     * 1. Division by 0 causes an exception.
     * 2. Dividing two integers results in an integer.
     *    The remainder is lost. See resultInt
     * 3. For more accurate results during integer division
     *    cast the operands to a float and obtain the results
     *    which will be a full representation. See resultFloat.
     */
    var val1 = 10;
    var val2 = 3;
    var val3 = 5;
    Console.WriteLine("The resultInt = " + (val1/val2));
    Console.WriteLine("The resultFloat = " + ((float)val1 / (float)val2));

    /*
     * Precedence:
     * Operator precedence in C# follows the mathematical rules. See resPrecedence.
     * To alter precedence within a C# application, use brackets or parentheses.
     */
    Console.WriteLine("The resPrecedence = " + (val1 + val2 * val3));   //Multiplication happens first
    Console.WriteLine("The resPrecedence = " + (val1 + val2) * val3);   //Operates from left to right.

    /*
     * Comparators:
     * Always return a boolean
     */
    Console.WriteLine("Is val1 greater than val2? " + (val1 > val2));
    Console.WriteLine("Is val1 equal to val2? " + (val1 == val2));
    Console.WriteLine("Is val1 not equal to val2? " + (val1 != val2));
    Console.WriteLine("Invert the result of (Is val1 not equal to val2?) " + !(val1 != val2));

    /*
     * Logical:
     * Get result of first comparison and (&& it) with the result of the second operation.
     * Get result of first comparison and (|| it) with the result of the second operation.
     */
    Console.WriteLine("Is val1 greater than both val2 and val3? " + ((val1 > val2) && (val1 > val3)));
    Console.WriteLine("Is val1 greater than val2 OR val3? " + ((val1 > val2) || (val1 > val3)));
}

/*
 * Classes
 * Basic building blocks of an application.
 * Ex below: Creating an object from a class.
 * Object: Instance of a class.
 */
{
    var car = new Car();
    car.SetMake("Ford");
    car.SetModel("Fiesta 1.4");
    car.SetMileage(156368.8);
    Console.WriteLine("My car is a " + car.GetMake() + " " + car.GetModel() + " with " 
        + car.GetMileage() + "km on the clock");
}

/*
 * Static Method Identifier
 * If a method is defined as 'static', it can be accessed via the class identifier itself.
 * For such a method, an instance/object does not need to be created before usage. In fact
 * static method cannot be accessed via an object. Static fields and methods can only keep
 * a single copy throughout the run such as Main() and Console().
 */
{
    Console.WriteLine("Adding 2 and 3 results in: " + Calculator.Add(2, 3));
}

/*
 * Structures: Struct
 */
{
    var mColor = new RbgColor("#eb4034", "#5beb34", "#347deb");
    Console.WriteLine("Possible colors are: " + mColor._red + " " + mColor._green + " " + mColor._blue);
}

/*
 * Arrays
 * Zero indexed with fixed size specified at declaration.
 * Initialized with new keyword to create a new object of type Array.
 * Below we initialize an array in two different ways.
 * Array elements are always initialized to the default value for the array type.
 * Ex: int => 0, boolean => false etc.
 */
{
    //Initialize an array using curly braces.
    int[] numbers = new int[3] { 1, 2, 3 };

    //Initialize an array using assignment to each array position.
    int[] values = new int[3];
    values[0] = 1;
    values[1] = 2;
    values[2] = 3;

    var names = new string[3]{"Jean", "Claude", "van Damme"};
    Console.WriteLine(names[0]);
    Console.WriteLine(names[1]);
    Console.WriteLine(names[2]);
}

/*
 * String:
 * Sequence of characters. Specified by double quotes.
 * Each char in a string is accessible via index position.
 * Immutable: Once created they cannot be changed. Methods
 * used to manipulate strings return a new string each time.
 */
{
    var names = new string[3] { "Jean", "Claude", "van Damme" };
    string hero = string.Join(",", names);
    Console.WriteLine("Action hero name: " + hero);

    var firstName = "Jakob";
    var lastName = "Membrane";
    var fullName = string.Format("My name is {0} {1}", firstName, lastName);

    var text = "Hi Jane.\nEdit the following files:\nC:\\folder\\contracts\\export.docx\nC:\\folder\\forms\\export.docx";
    Console.WriteLine(text);

    //Using verbatim string to format longer and complex strings
    var verbatimString = @"Hi Doe.
Sign the following files:
C:\folder\contracts\export.pdf
C:\folder\forms\export.pdf";
    Console.WriteLine(verbatimString);
}

/*
 * Enums, Value Types and Reference Types
 */
{
    var methodId = 3;
    Console.WriteLine("Shipping Method used: " + (ShippingMethod)methodId);
    Console.WriteLine("Id for the Shipping Method used:" + (int)((ShippingMethod)methodId));

    //Value Types
    var a = 10;
    var b = a;
    b++;
    Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

    //Reference Types
    var array1 = new int[3] { 1, 2, 3 };
    var array2 = array1;    //The memory address is copied, not the value
    array2[0] = 5;               //This modifies both array 1 and array 2 element [0] to 5 because they point to the same value in memory. 
    Console.WriteLine("array1: " + array1[0]);
    Console.WriteLine("array2: " + array2[0]);
}

/*
 * Conditionals and Iterations
 * If, Switch, Ternary operator.
 * foreach used to iterate through array list or similar
 * for loop used to iterate for a given number of iterations.
 * while loop to repeat a block of code while some condition remains true.
 * do while loop evaluates the condition at the end. So always executes at least once.
 * break keyword: to jump out of the loop.
 * continue keyword: to jump to the next iteration.
 */
{
    int hour = 10;
    var mConditionals = new ConditionalsClass();
    var mExercises = new Exercises();
    var LearningDateTime = new LearningDateTime();
    var workingWithString = new WorkingWithText();
    workingWithString.UsingStringBuilder();
    var workingWithFiles = new WorkingWithFiles();
    mConditionals.DayTimeDivider(hour);
    bool isMyCustomer = false;
    Console.WriteLine("The price for the customer is: " + mConditionals.GoldMarketPrice(isMyCustomer));
    var mySeason = ConditionalsClass.Seasons.Summer;
    mConditionals.SeasonsGreetings(mySeason);
    
    /*mExercises.UserInputValidator();
    mExercises.UserOutputMaximum();
    mExercises.UserImageLayout();
    mExercises.UserSpeedCapture();
    mConditionals.IterationMethods();*/
    mExercises.ExercisesVerTwo();
    var mLearnArrayList = new LearnArrayList();
    mLearnArrayList.PracticeArrays();
    mLearnArrayList.PracticeLists();
    /*mExercises.ArraysListsFacebookExercise();
    mExercises.ArraysListsReversalExercise();
    mExercises.ArraysListsNumExercise();
    mExercises.UniqueNumExercise();
    mExercises.AddRangeExample();*/
    LearningDateTime.DateInfoSession();
    LearningDateTime.TimeInfoSession();
    workingWithString.someExamples();
    //workingWithString.StringValidators();
    var sentence =
        "This sentence is a very long sentence because we are testing how to " +
        "summarize text or view shortened version of the string in the console";
    var summary = workingWithString.SummarizingText(sentence, 25);
    Console.WriteLine(summary);
    workingWithString.UsingStringBuilder();
    /*Console.WriteLine(mExercises.ConsecutiveNumbers());
    Console.WriteLine(mExercises.DuplicateNumbers());
    Console.WriteLine(mExercises.DateTimeExercise());
    Console.WriteLine(mExercises.StudentExercise());
    mExercises.VowelCounter();*/
    //workingWithFiles.someExample();
    mExercises.ReadTextFileContents();
    mExercises.DisplayLongestWord();
}