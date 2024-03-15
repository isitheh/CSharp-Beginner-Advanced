using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class LearnArrayList
{
    public LearnArrayList()
    {
    }

    public void PracticeArrays()
    {
        var numbers = new[] { 3, 7, 9, 2, 14, 6 };
        //Length() - represents the size of the array
        Console.WriteLine("Length of Array numbers = " + numbers.Length);
        //IndexOf - returns the index of the given val within the array
        Console.WriteLine("The index of 9 = " + Array.IndexOf(numbers, 9));
        //Clear() - Sets the elements to be cleared to a value of 0/false/null.
        //Start clearing at the beginning and clear for a length of 2 items.
        Array.Clear(numbers, 0, 2);
        Console.WriteLine("After clearing the first 2 elements, Array numbers = ");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        //Copy() - Source, destination, number of elements to copy
        var anotherArray = new int[3];
        Array.Copy(numbers, anotherArray, 3);
        Console.WriteLine("After copying the first array into second Array: ");
        foreach (var num in anotherArray)
        {
            Console.WriteLine(num);
        }

        //Sort() - Sorts the given array in ascending order
        Array.Sort(numbers);
        Console.WriteLine("After sorting Array numbers = ");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        //Reverse() - Returns the given array backwards.
        Array.Reverse(numbers);
        Console.WriteLine("After reversing the sorted Array numbers = ");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void PracticeLists()
    {
        Console.WriteLine("...Working with Lists...");
        var numbers = new List<int>() { 1, 2, 3, 4, };
        //Adds the given value to the end of the list.
        numbers.Add(1);
        //Adds the given values (Array form) to the end of the list.
        numbers.AddRange(new int[3] { 5, 6, 7 });
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        //IndexOf() - Returns the first index of the given value in the list.
        Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
        //LastIndexOf() - Returns the index of the last occurence of the given value.
        Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));
        //Count() - Returns the number of objects in the list.
        Console.WriteLine("1. List has " + numbers.Count() + " objects.");
        //Remove() - Removes the first occurence of the given object within the list. 
        //To remove all occurrences of a specific object within a list, iterate.
        for (var i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
            {
                numbers.Remove(numbers[i]);
            }
        }

        Console.WriteLine("After removing all the objects 1 from the numbers list: ");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        //Clear() - Removes all elements from the list.
        numbers.Clear();
        Console.WriteLine("2. List has " + numbers.Count() + " objects.");
    }
}
