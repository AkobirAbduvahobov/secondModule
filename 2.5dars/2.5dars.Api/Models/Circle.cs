namespace _2._5dars.Api.Models;

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Circle is drawing");
    }

    public double GetRadius()
    {
        return 2.5d;
    }

    public override void Foo()
    {
        Console.WriteLine("Child Fooing");
    }
}
