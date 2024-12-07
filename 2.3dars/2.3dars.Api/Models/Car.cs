namespace _2._3dars.Api.Models;

public class Car : Vehicle
{
    public int WheelDiametr { get; set; }

    public Car() : base("ss", 55)
    {
        Console.WriteLine("car ctor");
    }
}
