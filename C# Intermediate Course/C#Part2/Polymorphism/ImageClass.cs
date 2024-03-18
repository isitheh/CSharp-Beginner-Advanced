namespace C_Part2.Polymorphism;

public class ImageClass : ShapeClass
{
    public ImageClass()
    {
        
    }

    /*
     * Demo: Method Overriding
     * To define a method to Draw within ImageClass
     * have to override the Draw() from shape. This is
     * because the Image is not the only shape and it
     * is drawn differently to other shapes out there.
     * Keyword: 'override'
     */
    public override void Draw()
    {
        //New Implementation
        Console.WriteLine("Draw a image.");
    }
}