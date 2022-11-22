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
        
    }
}