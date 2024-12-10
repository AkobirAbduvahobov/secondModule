namespace _2._2dars.Api.Models;

public class YourClass : MyClass
{
    public YourClass() : base("") 
    {
        
    }

    public override void Do1()
    {
        Console.WriteLine("SALOM");
    }
    public override void Do()
    {
        Console.WriteLine("Do");
    }

    public void Do3()
    {
        Console.WriteLine("Do3");
    }
}
