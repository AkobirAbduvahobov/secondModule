namespace _2._8dars.Api;

public class MyList
{
    private int[] items;
    private int count;

    public MyList()
    {
        items = new int[4];
        count = 0;
    }

    public void AddItem(int item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count++] = item;
    }

    public int GetItemAt(int index)
    {
        CheckIndex(index);
        return items[index];
    }

    private void Resize()
    {
        var newItems = new int[items.Length * 2];
        for (var i = 0; i < items.Length; i++)
        {
            newItems[i] = items[i];
        }

        items = newItems;
    }

    private void CheckIndex(int index)
    {
        if (0 > index || count <= index)
        {
            throw new IndexOutOfRangeException();
        }
    }

}
