using System;

public class GoldFish
{
    private readonly Animal _animal;
    private readonly Swimmable _swimmable;

    public GoldFish(Animal animal, Swimmable swimmable)
    {
        _animal = animal;
        _swimmable = swimmable;
    }

    public void TheFishCan()
    {
        _animal.Eat();
        _animal.Sleep();
        _swimmable.Swim();
    }
}
