using System;

public class AssertExceptions
{
    public void ThrowException(String arg)
    {
        if (string.IsNullOrEmpty(arg)) { 
            throw new ArgumentException("Hello Args Exception.");
        }
    }
}
