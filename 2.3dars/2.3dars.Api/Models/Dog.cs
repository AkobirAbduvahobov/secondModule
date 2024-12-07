namespace _2._3dars.Api.Models;

public sealed class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"Dog is barking");
    }

    public override void Do()
    {
        Console.WriteLine("Dog do ishladi");
    }
}
