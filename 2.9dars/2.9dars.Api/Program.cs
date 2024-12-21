using _2._9dars.Api.Extensions;
using _2._9dars.Api.Models;
using System.Text;

namespace _2._9dars.Api;

internal class Program
{
    static void Main(string[] args)
    {

        List<Phone> phones = new List<Phone>();
        phones.Add(new Phone()
        {
            Model = "Samsung A55",
            Weight = 210,
        });

        phones.Add(new Phone()
        {
            Model = "Samsung S22",
            Weight = 250,
        });

        var res = phones.GetTotalWeight();
        Console.WriteLine(res);



        //var intValue = 458;
        //Console.WriteLine(intValue.GetRooms());
        //intValue.DecreaseValue(42);
        //Console.WriteLine(intValue);

        //StringBuilder sb = new StringBuilder("salom 45 45 ok 45");
        //Console.WriteLine(sb);
        //var res = sb.GetCountDigits();
        //Console.WriteLine(res);



        // Extension methods



        //Student student = new Student();
        //student.Password = "password";
        //student.Validate();


        //var number = 45;
        //var a = 0;
        //string s = "ok";


        //try
        //{
        //    //var res = number / a;
        //    //var b = s.Length;
        //    var c = s[7];
        //}
        //catch (NullReferenceException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    throw new IndexOutOfRangeException();
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Tugadi");
        //}



        //MyClass myClass = new MyClass();
        //int a = 4;
        //int b = 7;

        //string s1 = "salom";
        //string s2 = "hello";

        //myClass.MySwap<string>(ref s1, ref s2);
        //Console.WriteLine(s1);
        //Console.WriteLine(s2);
    }
}
