using System;

public class GenericList<T>
{
	public void Add<T>(T value)
	{
		//Add a value of Type T to the list.
	}

    public T this[int index]
    {
        get
        {
            throw new NotImplementedException(); 

        }
    }
}
