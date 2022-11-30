using Shared.Models;

namespace BinarySearchTree;

public class Tree<T> where T : IComparable
{
    public Node<T> Root { get; private set; }
}