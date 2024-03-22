using System;
/*
 * Utilities Class: IComparable
 * This class demonstrates a constraint to an interface.
 * Signified by "where T : ISomeInterface"
 * new () adds a constraint to a default constructor.
 */
public class Utilities<T> where T : IComparable, new()
{
	public int Max(int a, int b)
	{
		return (a > b ? a : b);
	}

    public void NowCanInstantiate()
    {
        //The reason we can instantiate T, here is because of the 
        //constraint new () above to introduce a default constructor
        var obj = new T();
    }

    public T Maximum(T a, T b)
    {
		return (a.CompareTo(b) > 0 ? a : b);
    }

}
