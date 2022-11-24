using Queue.Interfaces;

namespace Queue.Implementations;

public class CustomDeque <T> : ICustomDeque<T>
{
    private List<T> items = new();
    private T Head => items.LastOrDefault();
    private T Tail => items.FirstOrDefault();
    public int Count => items.Count;

    public CustomDeque()
    {
        
    }

    public CustomDeque(T data)
    {
        items.Add(data);
    }

    public void PushBack(T data)
    {
        items.Insert(0, data);
    }
    
    public void PushFront(T data)
    {
        items.Add( data);
    }

    public T PopBack()
    {
        var tail = Tail;
        items.Remove(tail);
        return tail;
    }

    public T PopFront()
    {
        var head = Head;
        items.Remove(head);
        return head;
    }

    public T PeekBack() => Tail;
    public T PeekFront() => Head;
}