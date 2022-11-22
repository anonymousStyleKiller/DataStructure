namespace CircularLinkedList.Interfaces;

public interface ICircularLinkedList<T>
{
    public void Add(T data);
    public void Remove(T data);
}