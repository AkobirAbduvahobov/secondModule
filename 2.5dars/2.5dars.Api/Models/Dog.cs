namespace _2._5dars.Api.Models;

public class Dog : Animal, IRun, ISwim, IEat
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine("Eating meat");
    }

    public void Run()
    {
        Console.WriteLine("Runing");
    }

    public void Swim()
    {
        throw new NotImplementedException();
    }

    public void Do()
    {
        throw new NotImplementedException();
    }
}
