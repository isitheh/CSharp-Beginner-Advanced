using System;
using AdvancedC_.Delegates;

public class PhotoFilters
{
    public void ApplyBrightness(Photo photo)
    {
        Console.WriteLine("Brighten the photo.");
    }
    public void ApplyContrast(Photo photo)
    {
        Console.WriteLine("Recontrast the photo.");
    }
    public void Resize(Photo photo)
    {
        Console.WriteLine("Resize the photo.");
    }
}
