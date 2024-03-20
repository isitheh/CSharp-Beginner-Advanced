namespace C_Part2.Composition;

public class PersonAnimal
{
    private readonly Animal _animal;
    private readonly Walkable _walkable;

    public PersonAnimal(Animal animal, Walkable walkable)
    {
        _animal = animal;
        _walkable = walkable;
    }

    public void ThePersonCan()
    {
        _animal.Eat();
        _animal.Sleep();
        _walkable.Walk();
    }
}