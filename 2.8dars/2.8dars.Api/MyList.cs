namespace _2._8dars.Api;

public class MyList<T> : IMyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4];
        count = 0;
    }

    public MyList(int capacity)
    {
        items = new T[capacity];
        count = 0;
    }

    public void AddItem(T item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count++] = item;
    }

    public T GetItemAt(int index)
    {
        CheckIndex(index);
        return items[index];
    }

    private void Resize()
    {
        var newItems = new T[items.Length * 2];
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

    public void RemoveItemAt(int index)
    {
        CheckIndex(index);
        for (var i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        count--;
        items[count] = default(T);

        // 4 9 5 8 3 7 9 => 2
        // 4 9 8 3 7 9 0

    }

    public void AddItemsRange(T[] nums)
    {
        foreach (var num in nums)
        {
            AddItem(num);
        }
    }

    public void ReplaceAllItems(T oldElement, T newElement)
    {
        for (var i = 0; i < count; i++)
        {
            if (object.Equals(items[i], oldElement))
            {
                items[i] = newElement;
            }
        }
    }

    public int GetItemIndex(T item)
    {
        for (var i = 0; i < count; i++)
        {
            if (object.Equals(items[i], item))
            {
                return i;
            }
        }

        return -1;
    }

    public int GetCount()
    {
        return count;
    }

    public int GetCapacity()
    {
        return items.Length;
    }


}
