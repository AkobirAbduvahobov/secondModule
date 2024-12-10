namespace _2._4dars.Api;

internal class Program
{
    static void Main(string[] args)
    {
        //Dog dog = new Dog();
        //dog.Age = 5;
        //dog.Name = "test";

        ////dog.Do1();
        ////dog.MakeVoice();
        ////dog.Do3();

        //Animal animal = new Dog();
        //animal.Name = "Rex";

        Animal animal = new Cat();
        animal.Name = "Mosh";
        animal.Do1();
        animal.MakeVoice();
        animal.Do3();  


        animal = new Dog();
        animal.Name = "Rex";
        animal.Do1();
        animal.MakeVoice();
        animal.Do3();



    }
}
