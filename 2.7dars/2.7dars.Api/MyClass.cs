namespace _2._7dars.Api;

public class MyClass
{
    private int[] items;
    private int count;
    public MyClass()
    {
        items = new int[4];
        count = 0;
    }

    public void AddItem(int item)
    {
        if(items.Count() == count)
        {
            Resize();
        }

        items[count++] = item;
    }


    public int GetItemAt(int index)
    {
        return items[index];
    }
    private void Resize()
    {
        var newSize = items.Count() * 2;
        var newArray = new int[newSize];
        for(var i = 0; i < items.Count(); i++)
        {
            newArray[i] = items[i];
        }

        items = newArray;
    }

}
