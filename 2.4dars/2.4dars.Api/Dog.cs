namespace _2._4dars.Api;

public class Dog : Animal
{
    public int Age { get; set; }
    public override void Do1()
    {
        Console.WriteLine("Dog do1() ");
    }

    public override void MakeVoice()
    {
        Console.WriteLine("Dog is barking");
    }
}
