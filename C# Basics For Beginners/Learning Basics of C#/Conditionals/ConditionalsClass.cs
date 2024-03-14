using System;

public class ConditionalsClass
{
    const int PasswordLength = 16;
    public enum Seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

	public ConditionalsClass()
	{
	}

    public void DayTimeDivider(int hour)
    {
        if (hour > 0 && hour < 12)
        {
            Console.WriteLine("It is the morning!");
        } else if (hour > 12 && hour < 18)
        {
            Console.WriteLine("It is the afternoon");
        }
        else
        {
            Console.WriteLine("It is the evening");
        }
    }

    public float GoldMarketPrice(bool isExistingCustomer)
    {
        return (isExistingCustomer ? 12.95f : 18.49f);
    }

    public void SeasonsGreetings(Enum season)
    {
        switch (season)
        {
            case Seasons.Spring:
                Console.WriteLine("Hooray: Its Spring. Trees are blossoming again.");    
                break;

            case Seasons.Summer:
                Console.WriteLine("Congrats: Its Summer. Time to work work work.");
                break;

            case Seasons.Autumn:
                Console.WriteLine("Yippie: Its Autumn. One last push for the ages.");
                break;

            case Seasons.Winter:
                Console.WriteLine("Grrrrrr: Its Winter. Time to enjoy the fruits of our labour.");
                break;

            default:
                Console.WriteLine("This is just global warming, aint it?");
                break;
        }
    }

    public void IterationMethods()
    {
        for (var i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("The value " + i + " is even");
            }
        }

        for (var i = 10; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("The value " + i + " is even");
            }
        }

        var name = "Muziwenkosi Nxele";
        /*for (var i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }*/

        foreach (var mChar in name)
        {
            Console.WriteLine(mChar);
        }

        var numbers = new int[] { 1, 2, 3 };
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        var k = 0;
        while (k <= 10)
        {
            if (k % 2 == 0)
            {
                Console.WriteLine("The value " + k + " is even");
            }
            k++;
        }

        while (true)
        {
            Console.Write("Type your name: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            Console.WriteLine("Echo: " + input);
        }

        //Random Number Generator - Type Int32 (int)
        var random = new Random();
        for (var i = 0; i < 10; i++)
        {
            //Generate random values between 1 and 10.
            Console.WriteLine(random.Next(1, 10));
        }

        //Use randomization to generate a 16 character
        //password based on random ascii characters.
        var mRandom = new Random();
        var buffer = new char[PasswordLength];
        for (var i = 0; i < PasswordLength; i++)
        {
            buffer[i] = (char)(mRandom.Next(33, 122));
        }
        var mPassword = new string(buffer);
        Console.WriteLine("Generated Password: " + mPassword);
    }
}
