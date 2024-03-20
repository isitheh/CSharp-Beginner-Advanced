using System;

public class DogAnimal
{
    private readonly Animal _animal;
    private readonly Walkable _walkable;

    public DogAnimal(Animal animal, Walkable walkable)
    {
        _animal = animal;
        _walkable = walkable;
    }

    public void TheDogCan()
    {
        _animal.Eat();
        _animal.Sleep();
        _walkable.Walk();
    }
}
