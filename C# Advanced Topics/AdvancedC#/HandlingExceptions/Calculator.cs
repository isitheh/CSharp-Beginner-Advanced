namespace AdvancedC_.HandlingExceptions;

public class Calculator
{
    public int Divide(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Can not divide with 0");
        }
        return numerator / denominator;
    }
}