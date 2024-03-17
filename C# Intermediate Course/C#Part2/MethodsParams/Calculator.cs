namespace C_Part2.MethodsParams;

public class Calculator		
{
    public Calculator()
    {
    }

    public int Add(params int[] numbers)
    {
        int result = 0;
        foreach (var number in numbers)
        {
            result += number;
        }
        return result;
    }
}