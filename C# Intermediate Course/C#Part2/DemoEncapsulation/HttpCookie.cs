namespace C_Part2.DemoEncapsulation;

public class HttpCookie
{
    /*
     * Dictionary:
     * In C#, a dictionary is a generic collection class used to store key/value pairs.
     * Uses a HashTable to store the values. Key must be unique, values may be duplicated.
     *
     */
    private readonly Dictionary<string, string> _dictionary = new();

    public DateTime Expiry { get; set; }
    /*
     * Declare an indexer
     */
    public string this[string key]
    {
        get => _dictionary[key];
        set => _dictionary[key] = value;
    }
}