namespace LinkedList.Interfaces;

public interface ILinkedList<T> : IEnumerable<T>
{
    public void Add(T data);
    public void Remove(T data);
    public void Clear();

    public void AddFirst(T data);

    public void InsertAfter(T target, T data);
}