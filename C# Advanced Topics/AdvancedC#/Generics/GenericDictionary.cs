using System;
using System.ComponentModel;

public class GenericDictionary<TKey, TValue>
{
	public GenericDictionary()
	{
	}

    public void Add(TKey key, TValue value)
    {
        Console.WriteLine("Add Item the Dictionary.");
        Console.WriteLine("Item to add is of type: {0}", key.GetType());
        Console.WriteLine("Item's value to add is of type: {0}", value.GetType());
    }
}
