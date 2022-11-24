using Queue.Interfaces;

namespace Queue.Implementations;

public class CustomQueue<T> : ICustomQueue<T>
{
    private List<T> items = new();
    private T Head => items.LastOrDefault();
    private T Tail => items.FirstOrDefault();
    public int Count => items.Count;

    public CustomQueue()
    {
    }

    public CustomQueue(T data)
    {
        items.Add(data);
    }

    public T Peek() => Head;
    public void Enqueue(T data) => items.Insert(0, data);

    public T Dequeue(T data)
    {
        var tail = Head;
        items.Remove(data);
        return tail;
    }
}