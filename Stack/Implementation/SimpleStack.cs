using Stack.Interfaces;

namespace Stack.Implementation;

public class SimpleStack<T> : IStack<T>
{
    private List<T> Items = new();
    public int Count => Items.Count;
    private bool IsEmpty => Items.Count == 0;

    public void Push(T item)
    {
        Items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty) throw new NullReferenceException("Stack is empty");
        var item = Items.LastOrDefault();
        Items.Remove(item);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty) throw new NullReferenceException("Stack is empty");
        return Items.LastOrDefault();
        
    }

    public void Clear()
    {
        Items.Clear();
    }

    public override string ToString()
    {
        return $"Stack with {Count} elements";
    }

    public object Clone()
    {
        var newStack = new SimpleStack<T>
        {
            Items = new List<T>(Items)
        };
        
        return newStack;
    }
}