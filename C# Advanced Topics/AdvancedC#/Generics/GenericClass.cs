using System;

/*
 * Created a generic class named "GenericClass"
 * with a generic alias T (Can say for Type).
 * new() here specifies a default constructor
 * and allows us to declare type T as new T()
 */
public class GenericClass<T> where T : Book
{
    private T _data;
    public GenericClass(T data)
    {
        _data = data;
    }

    //Declare a function that can tak in any
    //data type and print it to the console.
    public void GenericPrintable<T>(T input)
    {
        Console.WriteLine("Print the given input: " + input);
    }

    public void AnotherGenericPrintable()
    {
        Console.WriteLine("Print the data: " + this._data);
    }

    public void ForceGenericToReadBook()
    {
        _data.ReadBook();
    }
}
