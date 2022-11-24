namespace Queue.Interfaces;

public interface ICustomDeque<T>
{
    public void PushBack(T data);
    public void PushFront(T data);
    public T PopBack();
    public T PopFront();
    public T PeekBack();
    public T PeekFront();

}