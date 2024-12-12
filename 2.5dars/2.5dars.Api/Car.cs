namespace _2._5dars.Api;

public class Car : Vehicle
{
    public void Refuel(int amount)
    {
        Fuel += amount;
    }

    public void Drive(int distanse)
    {
        Console.WriteLine(distanse / Speed);
    }
}
