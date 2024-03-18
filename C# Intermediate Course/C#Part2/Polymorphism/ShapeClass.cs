namespace C_Part2.Polymorphism;

public abstract class ShapeClass
{
    public int  Width { get; set; }
    public int  Height { get; set; }
    public Position Position { get; set; }
    public ShapeClass()
    {
    }

    public abstract void Draw();
}