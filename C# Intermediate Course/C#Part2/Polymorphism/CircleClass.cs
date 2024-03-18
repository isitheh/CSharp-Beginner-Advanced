namespace C_Part2.Polymorphism;

public class CircleClass: ShapeClass
{
    public CircleClass()
    {
        
    }

    /*
     * Demo: Method Overriding
     * To define a method to Draw within CircleClass
     * have to override the Draw() from shape. This is
     * because the circle is not the only shape and it
     * is drawn differently to other shapes out there.
     * Keyword: 'override'
     */
    public override void Draw()
    {
        //New Implementation
        Console.WriteLine("Draw a circle.");
    }
}