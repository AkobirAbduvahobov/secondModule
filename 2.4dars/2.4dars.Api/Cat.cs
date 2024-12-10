using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4dars.Api;

public class Cat : Animal
{
    public override void Do1()
    {
        Console.WriteLine("Cat do1()");
    }

    public override void MakeVoice()
    {
        Console.WriteLine("cat is meowing");
    }
}
