namespace _2._8dars.Api;

public interface IMyList<T>
{
    void AddItem(T item);
    T GetItemAt(int index); 
    void RemoveItemAt(int index);
    void AddItemsRange(T[] nums);
    void ReplaceAllItems(T oldElement, T newElement);
    int GetItemIndex(T item);
    int GetCount();
    int GetCapacity();
    T[] ToArray();
    void InsertAt(int index, T item);
    void SortAsSelected();
    void SortAsBuble();
}
