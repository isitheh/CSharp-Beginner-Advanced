using System;

public class Names
{
    public string NickName { get; set; }
    public string GetFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}
