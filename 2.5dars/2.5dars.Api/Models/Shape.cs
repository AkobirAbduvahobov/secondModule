namespace _2._5dars.Api.Models;

public abstract class Shape
{
    public int CornerQuentity { get; set; }
    public abstract void Draw();

    public void Do()
    {
        Console.WriteLine("Doing");
    }

    public virtual void Foo()
    {
        Console.WriteLine("Fooing");
    }
}
