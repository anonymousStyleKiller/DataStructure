namespace Stack.Interfaces;

public interface IStack<T> : ICloneable
{
    public void Push(T item);
    public T Pop();
    public T Peek();

    public void Clear();
}