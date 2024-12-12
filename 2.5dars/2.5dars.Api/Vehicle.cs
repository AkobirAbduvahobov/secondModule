namespace _2._5dars.Api;

public class Vehicle
{
    protected int Speed { get; set; }
    protected double _fuel;

    protected double Fuel
    {
        get { return _fuel; }
        set
        {
            if (50 >= value + _fuel)
            {
                _fuel += value;
            }
        }
    }

}
