using System;

public class ChildWithProps
{

    //Declare the fields and the properties with Shorthand set and get.
    public string Name { set; get; }

    public DateTime Birthdate { private set; get; }
    public ChildWithProps(DateTime mDateTime)
	{
        this.Birthdate = mDateTime;
	}


    //Props Age field calculating age from the given birthdate.
    public int Age
    {
        get
        {
            var mTimeSpan = DateTime.Today - Birthdate;
            var years = mTimeSpan.Days / 365;
            return years;
        }
    }
}
