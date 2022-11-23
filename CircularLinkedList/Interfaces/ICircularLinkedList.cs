using System.Collections;

namespace CircularLinkedList.Interfaces;

public interface ICircularLinkedList<T> : IEnumerable
{
    public void Add(T data);
    public void Remove(T data);
}