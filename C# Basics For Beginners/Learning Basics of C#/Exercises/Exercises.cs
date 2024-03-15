namespace Learning_Basics_of_C_.Exercises;

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
        Console.WriteLine("Maximum is: " + System.Math.Max(num1, num2));
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
            int pointAboveLimit = System.Math.Abs(speedLimit - carSpeed);
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
        while (true) //Loop continuously
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

    public void ArraysListsFacebookExercise()
    {
        var friendsList = new List<string>();
        while (true) //Loop continuously
        {
            Console.WriteLine("Enter friends name: ");
            var nameInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameInput))
            {
                break;
            }
            else
            {
                friendsList.Add(nameInput);
            }
        }

        if (friendsList.Count != 0)
        {
            if (friendsList.Count == 1)
            {
                Console.WriteLine("[" + friendsList.ElementAt(0) + "]" + " likes your post.");
            }
            else if (friendsList.Count == 2)
            {
                Console.WriteLine("[" + friendsList.ElementAt(0) + "] and " +
                                  "[" + friendsList.ElementAt(1) + "]" + " like your post.");
            }
            else
            {
                Console.WriteLine("[" + friendsList.ElementAt(0) + "], " +
                                  "[" + friendsList.ElementAt(1) + "] and " + (friendsList.Count - 2)
                                  + " others like your post.");
            }
        }
        else
        {
            Console.WriteLine();
        }
    }

    public void ArraysListsReversalExercise()
    {
        var myName = new string("");
        while (true) //Loop continuously
        {
            Console.WriteLine("Enter your name: ");
            var nameInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameInput))
            {
                break;
            }
            else
            {
                myName = nameInput;
                break;
            }
        }

        Console.WriteLine("My Name = ");
        foreach (var t in myName)
        {
            Console.Write(t);
        }

        Console.WriteLine();
        var myNameArray = myName.ToCharArray().Reverse();
        Console.WriteLine("Reversed My Name = ");
        foreach (var t in myNameArray)
        {
            Console.Write(t);
        }
    }

    public void ArraysListsNumExercise()
    {
        var numbersArray = new int[5];
        int counter = 0;
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            var numInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numInput))
            {
                continue;
            }
            else
            {
                var aNumber = Convert.ToInt32(numInput);
                if (!numbersArray.Contains(aNumber))
                {
                    numbersArray[counter] = aNumber;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Try a different number.");
                }
            }

            if (counter == 5)
            {
                break;
            }
        }

        Array.Sort(numbersArray);
        Console.WriteLine("After sorting numbersArray = ");
        foreach (var mNum in numbersArray)
        {
            Console.WriteLine(mNum);
        }
    }

    public void UniqueNumExercise()
    {
        var numbersList = new List<int>();
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            var strInput = Console.ReadLine();
            if (strInput != null && strInput.Equals("Quit"))
            {
                break;
            }
            else
            {
                var aNumber = Convert.ToInt32(strInput);
                numbersList.Add(aNumber);
            }
        }

        Console.WriteLine("Populated Unique/Distinct List = ");
        foreach (var mNum in numbersList.Distinct())
        {
            Console.WriteLine(mNum);
        }
    }

    public void AddRangeExample()
    {
        var numbersList = new List<int>();
        while (true)
        {
            Console.WriteLine("Enter a comma separated list of numbers: ");
            var commaNumbersList = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(commaNumbersList))
            {
                Console.WriteLine("Invalid List, please retry.");
            }
            else
            {
                int countCommas = 0;
                foreach (char c in commaNumbersList)
                {
                    if (c == ',')
                    {
                        countCommas++;
                    }
                }

                if (countCommas < 4)
                {
                    Console.WriteLine("Invalid List, please retry.");
                }
                else
                {
                    Console.WriteLine(commaNumbersList);
                    string[] numArrStr = commaNumbersList.Split(',');
                    int[] numArr = Array.ConvertAll(numArrStr, int.Parse);
                    Array.Sort(numArr);
                    numbersList.AddRange(numArr);
                    break;
                }
            }
        }

        for (var i = 0; i < 3; i++)
        {
            Console.WriteLine(numbersList.ElementAt(i));
        }
    }

    public string ConsecutiveNumbers()
    {
        Console.WriteLine("Enter a hyphen separated list of numbers (Enter when done): ");
        var strInput = Console.ReadLine();
        Console.WriteLine(strInput);
        string[] numArrStr = strInput.Split('-');
        int[] numArr = Array.ConvertAll(numArrStr, int.Parse);
        Array.Sort(numArr);
        for (var i = 1; i < numArr.Length; i++)
        {
            if ((numArr[i] - numArr[i - 1]) != 1)
            {
                return "Not Consecutive.";
            }
        }

        return "Consecutive.";
    }

    public string DuplicateNumbers()
    {
        var numbersList = new List<int>();
        Console.WriteLine("Enter a hyphen separated list of numbers: ");
        var hyphenNumbersList = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(hyphenNumbersList))
        {
            return "No execution performed.";
        }

        string[] numArrStr = hyphenNumbersList.Split('-');
        int[] numArr = Array.ConvertAll(numArrStr, int.Parse);
        Array.Sort(numArr);
        numbersList.AddRange(numArr);
        if (numbersList.Count > numbersList.Distinct().Count())
        {
            return "Duplicate";
        }

        return "Distinct";
    }

    public string DateTimeExercise()
    {
        Console.WriteLine("Enter a time in 24hour format: ");
        var hyphenNumbersList = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(hyphenNumbersList))
        {
            return "Invalid Time";
        }

        var mTimeArr = hyphenNumbersList.Split(':');
        int mHour = Convert.ToByte(mTimeArr[0]);
        int mMinute = Convert.ToByte(mTimeArr[1]);
        int Seconds = 0;
        var mTimeSpan = new TimeSpan(mHour, mMinute, Seconds);
        var checkTimeSpan = new TimeSpan(24, 0, 0);
        if (checkTimeSpan.TotalSeconds > mTimeSpan.TotalSeconds)
        {
            return "Ok";
        }
        return "Invalid Time";
    }

    public string StudentExercise()
    {
        Console.WriteLine("Write a sentence: ");
        var sentence = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(sentence))
        {
            return "Invalid Sentence";
        }
        sentence = sentence.Trim().ToLower();
        var wordList = sentence.Split(' ');
        var wordsForSentence = new List<string>();
        foreach (var word in wordList)
        {
            wordsForSentence.Add((char.ToUpper(word[0]) + word.Substring(1)));
        }
        return (string.Join("", wordsForSentence));
    }

    public void VowelCounter()
    {
        Console.WriteLine("Enter a word: ");
        int count = 0;
        var word = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(word))
        {
            var charArr = word.ToCharArray();
            foreach (char mChar in charArr)
            {
                switch (mChar)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            Console.WriteLine(count);
        }
    }
}