namespace C_Part2.Inheritance;

public class Text : PresentationObject
{
    public int FontSize { get; set; }
    public string FontName { get; set; }

    public void AddHyperLink(string url)
    {
        Console.WriteLine("Added a link to " + url);
    }
}