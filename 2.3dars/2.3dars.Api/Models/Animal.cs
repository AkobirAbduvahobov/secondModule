namespace _2._3dars.Api.Models;

public class Animal
{
    protected string Name { get; set; }

    public string Color { get; set; }

    public int Age { get; set; }

    public string Type { get; set; }

    public virtual void Do()
    {
        Console.WriteLine("Animal do ishladi");
    }
}
