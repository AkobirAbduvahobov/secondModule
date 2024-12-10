namespace _2._4dars.Api;

public abstract class Animal
{
    public string Name { get; set; }

    public abstract void Do1();

    public virtual void MakeVoice()
    {
        Console.WriteLine("Animal Do2 virtual ovoz is meowing");
    }

    public void Do3()
    {
        Console.WriteLine($"Animal Do3 oddiy {Name}");
    }
    
}
