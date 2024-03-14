using System;

public class Exercises
{
    public Exercises()
    {
    }

    public void UserInputValidator()
    {
        Console.WriteLine("Enter number between 1-10 : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num != null)
        {
            Console.WriteLine((num > 0 && num <= 10) ? "Valid" : "Invalid");
        }
    }

    public void UserOutputMaximum()
    {
        Console.WriteLine("Enter number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Maximum is: " + Math.Max(num1, num2));
    }

    public void UserImageLayout()
    {
        Console.WriteLine("Enter photo width size: ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter photo height size: ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((width >= height) ? "Landscape" : "Portrait");
    }

    public void UserSpeedCapture()
    {
        Console.WriteLine("Enter the speed limit : ");
        int speedLimit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the speed of car : ");
        int carSpeed = Convert.ToInt32(Console.ReadLine());
        if (carSpeed <= speedLimit)
        {
            Console.WriteLine("Ok");
        }
        else
        {
            int pointAboveLimit = Math.Abs(speedLimit - carSpeed);
            if (pointAboveLimit > 12)
            {
                Console.WriteLine("Above by: " + pointAboveLimit + " Points. License Suspended.");
            }
            else if (pointAboveLimit > 10)
            {
                Console.WriteLine("Above by: " + pointAboveLimit + " Points. Handed " + 2 + " Demerit points.");
            }
            else if (pointAboveLimit > 5)
            {
                Console.WriteLine("Above by: " + pointAboveLimit + " Points. Handed " + 1 + " Demerit points.");
            }
            else
            {
                Console.WriteLine("Above by: " + pointAboveLimit + " Points. Handed " + 0 + " Demerit points.");
            }
        }
    }

    public void ExercisesVerTwo()
    {
        int counter = 0;
        for (var i = 1; i <= 100; i++)
        {
            //Check if value i is divisible by 3
            if (i % 3 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("There are " + counter + " numbers divisible by 3 between 1 and 100");
        //ContinuallyAskForNumberOkToExit();
        //ComputeFactorialResult();
        //GuessTheNumber();
    }

    public void GuessTheNumber()
    {
        //Generate a Random number 1-10
        var random = new Random();
        var powerBall = random.Next(1, 10);
        Console.WriteLine("Power Ball = " + powerBall);
        int count = 0;
        while (count < 4)
        {
            //Give a guess chance.
            Console.WriteLine("Guess a number (1-10): ");
            var numInput = Console.ReadLine();
            var aNumber = Convert.ToInt32(numInput);
            if (aNumber == powerBall)
            {
                //User hit the Jackpot
                Console.WriteLine("You hit the Jackpot with number : " + aNumber);
                break;
            }
            count++;
            if (count == 4)
            {
                //Exit Message
                Console.WriteLine("You Lose. Try again Next Week!");
            }
        }
        
    }

    public void ComputeFactorialResult()
    {
        Console.WriteLine("Enter a number: ");
        var numInput = Console.ReadLine();
        var aNumber = Convert.ToInt32(numInput);
        Console.WriteLine("The factorial of the number: " + numInput + " is: " + ComputeFactorial(aNumber));
    }

    public long ComputeFactorial(int aNumber)
    {
        if (aNumber == 0 || aNumber == 1)
        {
            return 1;
        }
        else
        {
            return (aNumber * ComputeFactorial(aNumber - 1));
        }
    }

    public void ContinuallyAskForNumberOkToExit()
    {
        int counter = 0;
        while (true)    //Loop continuously
        {
            Console.WriteLine("Enter a number: ");
            var numInput = Console.ReadLine();
            if (numInput.Equals("Ok"))
            {
                break;
            }
            else
            {
                counter++;
            }
        }

        Console.WriteLine("The user has entered: " + counter + " numbers");
    }
}