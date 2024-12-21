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

    public T[] ToArray()
    {
        if (items.Count() == count)
        {
            return items;
        }

        // 4 7 8 6 3 0 5 0 
        var newItems = new T[count];
        for (var i = 0; i < count; i++)
        {
            newItems[i] = items[i];
        }

        return newItems;
    }

    public void InsertAt(int index, T item)
    {
        if (items.Count() == count)
        {
            Resize();
        }
        CheckIndex(index);

        // 4 5 8 2 3 6 d d => 2 9
        for (var i = count; i >= index; i--)
        {
            items[i + 1] = items[i];
        }

        items[index] = item;
        count++;
    }

    public void SortAsSelected()
    {
        for (var i = 0; i < count; i++)
        {
            // 45 18 99 11 56 24
            // 11 18 99 45 56 24
            var minElement = items[i];
            var minIndex = i;
            for (var j = i + 1; j < count; j++)
            {
                if(Convert.ToInt32(items[j]) > Convert.ToInt32(minElement))
                {
                    minElement = items[j];
                    minIndex = j;
                }
            }

            var temp = items[i];
            items[i] = items[minIndex];
            items[minIndex] = temp;
        }
    }
    public void SortAsBuble()
    {
        // 45 15 44 44 23 16 98 52 35 74 25 63
        // 15 45 44 44 23 16 98 52 35 74 25 63
        // 15 44 45 44 23 16 98 52 35 74 25 63
        // 15 44 23 16 44 45 35 52 25 63 74 98
        // 
        for (var i = 0; i < count; i++)
        {
            for(var j = 0; j < count - i - 1; j++)
            {
                if(Convert.ToInt32(items[j]) < Convert.ToInt32(items[j+1]))
                {
                    var temp = items[j];
                    items[j] = items[j+1];
                    items[j+1] = temp;
                }
            }
        }
    }


}
