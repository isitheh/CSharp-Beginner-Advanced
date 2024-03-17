namespace C_Part2.ClassIntro;

public class Point
{
    public int X; public int Y;
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(Point newLocation)
    {
        if (newLocation != null) 
        {
            Move(newLocation.X, newLocation.Y);
        }
        /*if (newLocation == null)
        {
            throw new ArgumentNullException(nameof(newLocation));
        }*/
    }
}