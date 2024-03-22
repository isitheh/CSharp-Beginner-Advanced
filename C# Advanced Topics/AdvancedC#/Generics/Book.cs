using System;

public abstract class Book
{
    public int itemNum;
    public string Name;

    public void ReadBook()
    {
        Console.WriteLine($"{Name} is item {itemNum}");
    }
    /*
     * new() here specifies a default constructor
     * and allows us to declare type T as new T()
     */
    public T BookFactory<T>(string bookName) where T : Book, new()
    {
        //Create the T now
        T newBook = new T();
        return newBook;
    }
}

public class MageBook : Book
{

}
public class WarriorBook: Book
{

}
public class ArcherBook : Book
{

}
