using System;

public class UsingRefOut
{
	public UsingRefOut()
	{
	}

    public void RefIncMethod(ref int varIncrement)
    {
        varIncrement++;
    }

    public void RefIncMethod(int varIncrement)
    {
        varIncrement++;
    }
}
