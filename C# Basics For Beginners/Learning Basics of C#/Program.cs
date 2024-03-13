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

    /*
     * Prefix increment example:
     * In the example below, c is first incremented then assigned to d.
     * So the value of d and the value of c is both the final value of c;
     */
    int c = 1;
    int d = ++c;
    Console.WriteLine("The value of c = " + c);
    Console.WriteLine("The value of d = " + d);

}