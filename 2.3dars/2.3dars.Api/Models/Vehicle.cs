namespace _2._3dars.Api.Models;

public class Vehicle
{
    public string Name { get; set; }

    public Vehicle(string name, int son)
    {
        Console.WriteLine("Vehicle ctor");
    }
}
