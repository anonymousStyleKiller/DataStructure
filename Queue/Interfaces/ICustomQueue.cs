namespace Queue.Interfaces;

public interface ICustomQueue<T>
{
    public T Peek();
    public void Enqueue(T data);
    public T Dequeue(T data);
}