namespace _2._5dars.Api.Models;

public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Square is drawing");
    }

    public double GetPerimeter()
    {
        return 8;
    }
}
