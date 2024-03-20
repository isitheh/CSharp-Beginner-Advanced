namespace C_Part2.Composition;

public class Duck
{
    private readonly Animal _animal;
    private readonly Walkable _walkable;
    private readonly Swimmable _swimmable;

    public Duck(Animal animal, Walkable walkable, Swimmable swimmable)
    {
        _animal = animal;
        _walkable = walkable;
        _swimmable = swimmable;
    }

    public void TheDuckCan()
    {
        _animal.Eat();
        _animal.Sleep();
        _walkable.Walk();
        _swimmable.Swim();
    }
}