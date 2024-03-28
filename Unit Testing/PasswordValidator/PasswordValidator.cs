using System;
using System.Text.RegularExpressions;

public class PasswordValidator: IPasswordValidator
{
    /*
     * This method should return true if the 
     * password is valid and false if it is not.
     * Criteria for a valid password are:
     *  Minimum 8 characters
     *  At least one capital letter
     */
    public bool ValidatePassword(string password)
    {
        var errorCounter = Regex.Matches(password, @"[a-zA-Z]").Count;
        if (errorCounter == 0)
        {
            Console.WriteLine("Returns false 1");
            return false;
        }
        if (password.Length < 8)
        {
            return false;
        }
        else
        {
            if(password == password.ToLower())
            {
                return false;
            }
            return true;
        }
    }
}

