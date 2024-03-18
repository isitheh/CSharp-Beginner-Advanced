namespace C_Part2.Polymorphism;

public class Canvas
{
    public Canvas()
    {
        
    }

    public void DrawShapes(List<ShapeClass> shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}