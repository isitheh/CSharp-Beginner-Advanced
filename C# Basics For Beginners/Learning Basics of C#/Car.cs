using System;

public class Car
{
    private string _make;
    private string _model;
    private double _mileage;
	public Car()
	{
	}

    public void SetMake(string make)
    {
        this._make = make;
    }

    public string GetMake()
    {
        return this._make;
    }

    public void SetModel(string model)
    {
        this._model = model;
    }

    public string GetModel()
    {
        return this._model;
    }

    public void SetMileage(double mileage)
    {
        this._mileage = mileage;
    }

    public double GetMileage()
    {
        return this._mileage;
    }
}
