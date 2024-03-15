using System;
using System.Globalization;
using System.Xml;
using Microsoft.VisualBasic;

public class LearningDateTime
{
    public LearningDateTime()
    {
    }

    public void DateInfoSession()
    {
        var dateTime = new DateTime(2015, 1, 1);
        //Now() method gives date and time.
        var now = DateTime.Now;
        //To access just today's date
        var today = DateTime.Today;
        //To access the various properties of the DateTime objects
        Console.WriteLine("Hour: " + now.Hour);
        Console.WriteLine("Minute: " + now.Minute);
        Console.WriteLine("Day of Month: " + today.Day);
        Console.WriteLine("Day of Year: " + today.DayOfYear);
        Console.WriteLine("Today's date: " + today.Date);
        //Show tomorrow's date based on today's info.
        //New Object returned as DateTime objects are immutable.
        Console.WriteLine("Tomorrow: " + now.AddDays(1));
        //Show yesterday's date based on today's info.
        Console.WriteLine("Yesterday: " + now.AddDays(-1));

        //Long and short date and time conversions
        Console.WriteLine("Local Date and Time: " + now.ToLocalTime());
        Console.WriteLine("Long Date: " + now.ToLongDateString());
        Console.WriteLine("Short Date: " + now.ToShortDateString());
        Console.WriteLine("Long Time: " + now.ToLongTimeString());
        Console.WriteLine("Short Time: " + now.ToShortTimeString());

        //Format Specifier. To obtain the date and time in a specific format
        Console.WriteLine("Full Non-Formatted Date: " + now.ToString(CultureInfo.CurrentCulture));
        Console.WriteLine("Full Formatted Date: " + now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        Console.WriteLine("Short Formatted Date: " + now.ToString("yyyy-MM-dd HH:mm:ss"));
    }

    public void TimeInfoSession()
    {
        var mTimeSpan = new TimeSpan(1, 2, 3);
        //The result of two dates calc is a timespan.
        var startTime = DateTime.Now;
        var endTime = DateTime.Now.AddMinutes(130);
        var duration = endTime - startTime;
        //Time that has passed between start and end is 2 hours and 10 minutes.
        Console.WriteLine(duration);

        //Read TimeSpan Object's Properties
        mTimeSpan = duration;
        //Minutes prop returns just the minutes component of the TimeSpan object.
        Console.WriteLine("Minutes: " + mTimeSpan.Minutes);
        //TotalMinutes prop converts and returns the total minutes of the TimeSpan object.
        Console.WriteLine("TotalMinutes: " + mTimeSpan.TotalMinutes);

        //On modification, a new Object returned as DateTime objects are immutable.
        //Add() - Add the given minutes to the current timespan.
        mTimeSpan = mTimeSpan.Add(TimeSpan.FromMinutes(8));
        Console.WriteLine("Add minutes to timespan: " + mTimeSpan);
        //Subtract() - Subtracts the given hours from the current timespan.
        mTimeSpan = mTimeSpan.Subtract(TimeSpan.FromHours(1));
        Console.WriteLine("Add minutes to timespan: " + mTimeSpan);

        //TimeSpan ToString Methods
        Console.WriteLine("ToString: " + mTimeSpan.ToString());
    }
}
