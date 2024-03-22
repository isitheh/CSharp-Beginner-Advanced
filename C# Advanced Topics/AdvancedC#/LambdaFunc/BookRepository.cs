namespace AdvancedC_.LambdaFunc;

public class BookRepository
{
    public List<MyBook> GetBooks()
    {
        return new List<MyBook>
        {
            new MyBook() { Title = "Mary Had Lamb", Price = 17.99f },
            new MyBook() { Title = "Old McDonald Had Farm", Price = 5 },
            new MyBook() { Title = "Duck Duck Goose", Price = 12 },
            new MyBook() { Title = "Among Us", Price = 7 },
            new MyBook() { Title = "Red Light, Green Light", Price = 9 },
            new MyBook() { Title = "Red Light, Green Light", Price = 7 },
        };
    }
}