using System;

public class Person
{
    private string firstName = "";
    private string lastName = "";
    private byte age = 0;
    private string area = "";
    public static int peopleCount = 0;

    public Person()
    {
    }

    public Person(string firstName, string lastName, byte age, string area)
	{
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.area = area;
    }

    public void Introduce()
    {
        Console.WriteLine("My Name is: {0} {1}, I am {2} years old, I am from {3}", firstName, lastName, age, area);
        peopleCount++;
    }

    /*
     * Given a persons info. Parse it such that it creates a Person object.
     */
    public static Person ParseFromName(string firstName, string lastName, byte age, string area)
    {
        var person = new Person();
        person.firstName = firstName;
        person.lastName = lastName;
        person.age = age;
        person.area = area;
        return person;
    }
}
