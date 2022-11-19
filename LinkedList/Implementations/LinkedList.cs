using System.Collections;
using LinkedList.Interfaces;
using Shared.Models;

namespace LinkedList.Implementations;

/// <summary>
/// Single linked list
/// </summary>
/// <typeparam name="T"></typeparam>
public class LinkedList<T> : ILinkedList<T>
{
    /// <summary>
    /// First element of list
    /// </summary>
    public Item<T> Head { get; private set; }
    /// <summary>
    /// Last element of list
    /// </summary>
    public Item<T> Tail { get; private set; }
    /// <summary>
    /// Count of lsit
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Create empty list
    /// </summary>
    public LinkedList()
    {
        Clear();
    }
    
    /// <summary>
    /// Remove all elements
    /// </summary>
    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    /// <summary>
    /// Add data to beginning list 
    /// </summary>
    /// <param name="data"></param>
    public void AddFirst(T data)
    {
        var item = new Item<T> (data){ Next = Head };
        Head = item;
        Count--;
    }

    public void InsertAfter(T target, T data)
    {
        if (Head != null)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(target))
                {
                    var item = new Item<T>(data);
                    item.Next = current.Next;
                    current.Next = item;
                    Count++;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }
           
            
        }
    }

    /// <summary>
    /// Create list with first element
    /// </summary>

    public LinkedList(T data)
    {
        SetHeadAndTail(data);
    }
    
    /// <summary>
    /// Add new item to end of list 
    /// </summary>
    /// <param name="data"></param>

    public void Add(T data)
    {
       
        if (Tail != null)
        {
            var item = new Item<T>(data);
            Tail.Next = item;
            Tail = item;
            Count++;
        }
        else
        {
            SetHeadAndTail(data);
        }
    }

    /// <summary>
    /// Remove first entry item 
    /// </summary>
    /// <param name="data"></param>
    public void Remove(T data)
    {
        if (Head != null)
        {
            if (Head.Value.Equals(data))
            {
                Head = Head.Next;
                Count--;
                return;
            }
            
            var current = Head.Next;
            var previous = Head;
            while (current.Next != null)
            {
                if (current.Value.Equals(data))
                {
                    previous.Next = current.Next;
                    Count--;
                    return;
                }

                previous = current;
                current = current.Next;
            }
        }
    }

    private void SetHeadAndTail(T data)
    {
        var item = new Item<T>(data);
        Head = item;
        Tail = item;
        Count = 1;
    }

    
    /// <summary>
    /// For IEnumerator 
    /// </summary>
    public IEnumerator<T> GetEnumerator()
    {
        var current = Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        return "Linked List" + Count + " elements";
    }
}