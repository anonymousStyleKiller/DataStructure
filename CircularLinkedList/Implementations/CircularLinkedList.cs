using System.Collections;
using CircularLinkedList.Interfaces;
using Shared.Models;

namespace CircularLinkedList.Implementations;

public class CircularLinkedList<T> : ICircularLinkedList<T>
{
    public DoubleItem<T>? Head { get; set; }
    public int Count { get; set; }

    public CircularLinkedList()
    {
    }

    public CircularLinkedList(T data)
    {
        SetHeadItem(data);
    }

    private void SetHeadItem(T data)
    {
        Head = new DoubleItem<T>(data);
        Head.Next = Head;
        Head.Prev = Head;
        Count = 1;
    }

    public void Add(T data)
    {
        if (Count == 0)
        {
            SetHeadItem(data);
            return;
        }

        var item = new DoubleItem<T>(data);
        item.Next = Head;
        item.Prev = Head.Prev;
        Head.Prev.Next = item;
        Head.Prev = item;
        Count++;
    }

    public void Remove(T data)
    {
        if (Head.Data.Equals(data))
        {
            RemoveItem(Head);
            Head = Head.Next;
            return;
        }

        var current = Head.Next;
        for (var i = Count; i > 0; i--)
        {
            if (current != null && current.Data.Equals(data))
            {
                RemoveItem(current);
            }

            current = current.Next;
        }
    }

    private void RemoveItem(DoubleItem<T> current)
    {
        current.Prev.Next = current.Next;
        current.Next.Prev = current.Prev;
        Count--;
    }

    public IEnumerator GetEnumerator()
    {
        var current = Head;
        for (var i = 0; i < Count; i++)
        {
            yield return current;
            current = current.Next;
        }
    }
    
}