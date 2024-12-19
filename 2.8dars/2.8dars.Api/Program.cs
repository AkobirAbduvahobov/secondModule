namespace _2._8dars.Api;

internal class Program
{
    static void Main(string[] args)
    {
        // Generic =>
        
        MyList myList = new MyList();
        myList.AddItem(15);
        myList.AddItem(88);
        myList.AddItem(77);
        myList.AddItem(23);
        myList.AddItem(82);


        Console.WriteLine(myList.GetItemAt(1));
        Console.WriteLine(myList.GetItemAt(3));
        Console.WriteLine(myList.GetItemAt(5));
        Console.WriteLine(myList.GetItemAt(9));



    }
}

