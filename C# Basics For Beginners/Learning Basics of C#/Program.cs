// See https://aka.ms/new-console-template for more information
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
 * Variable must first be assigned a value before being used.
 * 2. A variable of type float is initialised with a floating point value
 * followed by an 'f'. Without the 'f' the variable gets treated as a double.
 * 3. A character is initialised with single quotation marks while a string 
 * is initialised with using double quotation marks.
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
