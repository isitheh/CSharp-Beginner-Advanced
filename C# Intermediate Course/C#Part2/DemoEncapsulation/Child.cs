using System;

public class Child
{
    private string _name;
    private DateTime _birthdate;

	public Child()
	{
	}

    public void SetName(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            this._name = name;
        }
    }

    public string GetName()
    {
        return this._name;
    }

    public void SetBirthDate(DateTime birthdate)
    {
        this._birthdate = birthdate;
    }

    public DateTime GetBirthdate()
    {
        return this._birthdate;
    }
}
