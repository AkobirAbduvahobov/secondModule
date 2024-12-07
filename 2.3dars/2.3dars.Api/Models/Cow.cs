namespace _2._3dars.Api.Models;

public class Cow : Mamal
{
    public void Muu()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Feeding year : {FeedingYear}");
    }

    public void SetName(string name)
    {
        Name = name;
    }
}

