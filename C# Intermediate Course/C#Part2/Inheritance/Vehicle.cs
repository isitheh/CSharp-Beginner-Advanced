namespace C_Part2.Inheritance;

public class Vehicle
{
    private readonly string _registrationNumber;

    /*public Vehicle()
    {
        Console.WriteLine("Vehicle initialized!");
    }*/

    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
        Console.WriteLine("Vehicle initialized! Reg: " + registrationNumber);
    }
}