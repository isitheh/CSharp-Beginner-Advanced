using System;
using System.Collections;

public class BoxUnBox
{
	public BoxUnBox()
	{
	}

    public void BusyBoxing()
    {
        var nameList = new List<String>();
        nameList.Add("MaThethwayo");
        nameList.Add("Jobe");
        nameList.Add("Malume");
        foreach (var name in nameList)
        {
            Console.WriteLine("My name is: " + name);
        }
        
    }
}
