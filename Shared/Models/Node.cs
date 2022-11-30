namespace Shared.Models;

public class Node<T> : IComparable
    where T: IComparable
{
    public T Data { get; private set; }
    public Node<T> Left { get; private set; }
    public Node<T> Right { get;private set; }

    public Node(T data)
    {
        Data = data;
    }

    public Node(T data, Node<T> left, Node<T> right)
    {
        Data = data;
        Left = left;
        Right = right;
    }
    
    public int CompareTo(object? obj)
    {
        if (obj is Node<T>) return Data.CompareTo(obj);
        throw new ArgumentException("Not comparer types");
    }
}