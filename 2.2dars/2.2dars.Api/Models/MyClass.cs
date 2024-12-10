namespace _2._2dars.Api.Models;

public abstract class MyClass
{
    protected MyClass(string name)
    {

    }
    public string Name { get; set; }

    public abstract void Do();


    public virtual void Do1()
    {
        Console.WriteLine("Do1");
    }

    public void Do2()
    {
        Console.WriteLine("Do2");
    }
}
