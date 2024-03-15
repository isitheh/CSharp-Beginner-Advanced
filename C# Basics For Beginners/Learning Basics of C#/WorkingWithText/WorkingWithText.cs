using System;
using System.Text;

public class WorkingWithText
{
    public WorkingWithText()
    {
    }

    /*
     * Convert string to a number:
     * Using int.Parse(string) returns an exception if the string is null.
     * Using Convert.ToInt32(string) returns 0 if the string is null.
     * The method trim() gets rid of the whitespace before and after the string.
     */
    public void someExamples()
    {
        var fullName = " Sthe Gama ";
        fullName = fullName.Trim();
        Console.WriteLine("Trimmed fullName: '{0}'", fullName);
        Console.WriteLine("To Upper fullName: '{0}'", fullName.ToUpper());
        string firstName = fullName.Split(' ')[0];
        string lastName = fullName.Split(' ')[1];
        Console.WriteLine("Using the Split Method Approach Below:");
        Console.WriteLine("firstName: '{0}'", firstName);
        Console.WriteLine("lastName: '{0}'", lastName);
        Console.WriteLine("Using the IndexOf Method Approach Below:");
        int separatorIndex = fullName.IndexOf(' ');
        Console.WriteLine("firstName: '{0}'", fullName.Substring(0, separatorIndex));
        Console.WriteLine("lastName: '{0}'", fullName.Substring((separatorIndex + 1)));
        Console.WriteLine("Replace shorthand name with full first name.");
        fullName = fullName.Replace("Sthe", "Sithembiso");
        Console.WriteLine("fullName: '{0}'", fullName);
    }

    public void StringValidators()
    {
        Console.WriteLine("Enter Your Age: ");
        var numInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(numInput))
        {
            var aNumber = Convert.ToInt32(numInput);
            Console.WriteLine("My age is: " + aNumber);
        }

        float price = 18.98f;
        Console.WriteLine("The price of milk: " + price.ToString("C"));
    }

    public string SummarizingText(string sentence, int maxLen = 20)
    {
        if (sentence.Length <= maxLen)
        {
            return sentence;
        }

        var words = sentence.Split(' ');
        var summaryWords = new List<string>();
        int totalSummaryLength = 0;
        foreach (var word in words)
        {
            summaryWords.Add(word);
            totalSummaryLength += word.Length + 1;
            if (totalSummaryLength > maxLen)
            {
                break;
            }
        }
        return string.Join(' ', summaryWords);
    }

    public void UsingStringBuilder()
    {
        var builder = new StringBuilder();
        //Append a dash character 10 times
        builder
            .Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10)
            .AppendLine()
            .Append("Body")
            .AppendLine()
            .Append('-', 10)
            .AppendLine()
            .Append("Footer")
            .AppendLine()
            .Append('-', 10)
            .Insert(11, new string('-', 10));
        Console.WriteLine(builder);
    }
}
