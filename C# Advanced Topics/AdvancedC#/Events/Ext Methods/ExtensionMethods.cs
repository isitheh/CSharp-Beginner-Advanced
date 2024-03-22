using System;

public static class ExtensionMethods
{
    public static string Shorten(this string str, int numOfWords)
    {
        if (numOfWords <= 0)
        {
            throw new ArgumentOutOfRangeException("Number of words in the string inscufficient.");
        }

        var words = str.Split(' ');
        if (words.Length <= numOfWords)
        {
            return str;
        }

        return string.Join(" ", words.Take(numOfWords)) + "...";

    }
}
