using System.Collections;
using test;

class Program
{
    static void Main(string[] args)
    {
        int a1 = 45;
        string s1 = "abc";
        Person person = new Person();

        object obj1 = a1;
        object obj2 = s1;
        object obj3 = person;

        ArrayList list = new ArrayList();

        Dictionary<string, string> dic = new Dictionary<string, string>();

        LinkedList<string> lst = new LinkedList<string>();  

        Stack stack = new Stack();
        stack.Push("a");
        stack.Push(3);
        Stack<string> stackStrings = new Stack<string>();
        stackStrings.Push("a");
        stackStrings.Push("b");
        stackStrings.Push("c");
        stackStrings.Push("d");

        Console.WriteLine(stackStrings.Peek());
        Console.WriteLine(stackStrings.Peek());

        Console.WriteLine(stackStrings.Pop());
        Console.WriteLine(stackStrings.Peek());



    }
}