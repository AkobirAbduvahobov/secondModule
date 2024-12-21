using System.Text;

namespace _2._8dars.Api;

internal class Program
{
    static void Main(string[] args)
    {
        // Generic =>


        //List<int> list = new List<int>();


        var myList = new MyList<int>(5);
        myList.AddItem(15);
        myList.AddItem(88);
        myList.AddItem(77);
        myList.AddItem(23);
        myList.AddItem(82);

        //myList.SortAsSelected();
        myList.SortAsBuble();

        for (var i = 0; i < myList.GetCount(); i++)
        {
            Console.WriteLine(myList.GetItemAt(i));
        }

       



        //Console.WriteLine(myList.GetCount());
        //Console.WriteLine(myList.GetCapacity());

        //myList.RemoveItemAt(1);

        //Console.WriteLine(myList.GetCount());
        //Console.WriteLine(myList.GetCapacity());


        //MyList<string> list = new MyList<string>(8);

        //list.AddItem("salom");
        //list.AddItem("hello");

        //var item0 = list.GetItemAt(0);
        //var item1 = list.GetItemAt(1);

        //Console.WriteLine(item0);
        //Console.WriteLine(item1);

        //Console.WriteLine(list.GetCapacity());
        //Console.WriteLine(list.GetCount());


        //List<string> list2 = new List<string>();    
        //IList<string> list3 = new List<string>();   

        //list2.ToArray();
        //list3.ToArray();

        //Point3D point2D = new Point3D(7,6);
        //var res = point2D.DistanceFromOrigin();
        //Console.WriteLine(res);

        //Person person1 = new Person()
        //{
        //    Name = "Foo1",
        //    Age = 2,
        //};

        //Person person2 = new Person()
        //{
        //    Name = "Foo2",
        //    Age = 5,
        //};




    }
}

