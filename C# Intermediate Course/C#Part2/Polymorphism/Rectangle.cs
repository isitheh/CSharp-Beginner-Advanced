namespace C_Part2.Polymorphism;

public class Rectangle: ShapeClass
{
    public Rectangle()
    {
        
    }

    /*
     * Demo: Method Overriding
     * To define a method to Draw within Rectangle
     * have to override the Draw() from shape. This is
     * because the Rectangle is not the only shape and it
     * is drawn differently to other shapes out there.
     * Keyword: 'override'
     */
    public override void Draw()
    {
        //New Implementation
        Console.WriteLine("Draw a rectangle.");
    }
}