namespace AdvancedC_.Generics;
/*
 * Nullable Class: struct
 * This class demonstrates a constraint to a value type.
 * Signified by "where T : struct" - Means that
 * T can be a value type (int, char, bool etc. - primitives)
 */
public class Nullable<T> where T : struct
{
    private readonly object _value;

    public Nullable()
    {
        
    }

    public Nullable(T value)
    {
        _value = value;
    }

    public bool HasValue
    {
        get { return _value != null; }
    }

    public T GetValueOrDefault()
    {
        if (HasValue)
        {
            return (T)_value;
        }

        return default(T);
    }
}