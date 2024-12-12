using _2._5dars.Api.Enums;
using _2._5dars.Api.Models;
using System.Dynamic;

namespace _2._5dars.Api;

internal class Program
{
    static void Main(string[] args)
    {
        Accaunt accaunt = new Accaunt();

        accaunt.Password = "qwerty1212";
        Console.WriteLine(accaunt.Password);


        // Encapsulation

        




        //User user = new User();
        //user.Status = UserStatus.SuperAdmin;
        //user.Gender = UserGender.MALE;

        //Console.WriteLine((int)user.Status);
        //Console.WriteLine(user.Status);
        //Console.WriteLine((UserStatus)0);


        //Shape shape1 = new Circle();
        //Shape shape2 = new Square();

        //shape1.Foo();
        //shape2.Foo();
        //Shape shape = new Circle();
        //Circle circle = new Circle();

        //shape.Draw();
        //circle.Draw();

        //shape.Foo();
        //circle.Foo();

        //shape.Do(); // Doing
        //circle.Do(); // Doing
    }
}
