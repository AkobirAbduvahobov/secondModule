namespace _2._3dars.Api.Models;

public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine($"{Name} is meowing, color : {Color}");
    }

    public void SetName(string name )
    {
        Name = name;
    }
}
