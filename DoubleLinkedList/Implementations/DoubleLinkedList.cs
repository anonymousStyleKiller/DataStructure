using System.Collections;
using DoubleLinkedList.Interfaces;
using Shared.Models;

namespace DoubleLinkedList.Implementations;

public class DoubleLinkedList<T> : IDoubleLinkedList<T>
{
    public DoubleItem<T> Head { get; set; }
    public DoubleItem<T> Tail { get; set; }
    public int Count { get; set; }

    public DoubleLinkedList()
    {
        
    }
    public DoubleLinkedList(T data)
    {
        var item = new DoubleItem<T>(data);
        if (Count != 0) return;
        Head = item;
        Tail = item;
        Count = 1;
    }

    public void Add(T data)
    {
        var item = new DoubleItem<T>(data);
        Tail.Next = item;
        item.Prev = Tail;
        Tail = item;
        Count++;
    }

    public void Remove(T data)
    {
        var current = Head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
                Count--;
                return;
            }

            current = current.Next;
        }
    }

    public IDoubleLinkedList<T> Reverse()
    {
        var result = new DoubleLinkedList<T>();
        var current = Tail;
        
        while (current != null)
        {
            result.Add(current.Data);
            current = current.Prev;
        }

        return result;
    }

    public IEnumerator GetEnumerator()
    {
        var current = Head;
        while (current != null)
        {
            yield return current;
            current = current.Next;
        }
    }
    
    

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}