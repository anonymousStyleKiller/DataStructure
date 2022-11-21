using System.Collections;

namespace DoubleLinkedList.Interfaces;

public interface IDoubleLinkedList<T>  : IEnumerable
{
    public void Add(T data);
    public void Remove(T data);

    public IDoubleLinkedList<T> Reverse();
}