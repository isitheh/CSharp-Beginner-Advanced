using System;

public class Animal
{
    private int Age { get; set; }
	public Animal()
	{
	}

    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}
