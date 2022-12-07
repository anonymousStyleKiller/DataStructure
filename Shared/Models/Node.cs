namespace Shared.Models;

public class Node<T> : IComparable, IComparable<T>
    where T : IComparable, IComparable<T>
{
    public T Data { get; private set; }
    public Node<T> Left { get; private set; }
    public Node<T> Right { get; private set; }

    public Node(T data)
    {
        Data = data;
    }

    public  Node(T data, Node<T> left, Node<T> right)
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

    public int CompareTo(T? other)
    {
        throw new NotImplementedException();
    }

    public void Add(T data)
    {
        var node = new Node<T>(data);
        if (node.Data.CompareTo(Data) == -1)
        {
            if (Left == null)
            {
                Left = node;
            }
            else
            {
                Left.Add(data);
            }
        }
        else
        {
            if (Right == null)
            {
                Right = node;
            }
            else
            {
                Right.Add(data);
            }
        }
    }

    public override string ToString()
    {
        return Data.ToString();
    }
}