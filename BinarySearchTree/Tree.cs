using Shared.Models;

namespace BinarySearchTree;

public class Tree<T> where T : IComparable, IComparable<T>
{
    public Node<T> Root { get; private set; }
    public int Count { get; set; }

    public void Add(T data)
    {
        var node = new Node<T>(data);
        if (Root == null)
        {
            Root = node;
            Count = 1;
            return;
        }

        Root.Add(data);
        Count++;
    }
}