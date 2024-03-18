namespace C_Part2.Inheritance;

public class Car : Vehicle
{
    public Car(string registrationNumber) 
        : base(registrationNumber)
    {
        Console.WriteLine("Car initialized! Reg: " + registrationNumber);
    }
}