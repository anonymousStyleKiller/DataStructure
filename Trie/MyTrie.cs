using Shared.Models;

namespace Trie;

public class MyTrie<T>
{
    private NodeTrie<T> _root;
    public int Count { get; set; }

    public MyTrie()
    {
        _root = new NodeTrie<T?>('\0', default(T));
        Count = 1;
    }

    public void Add(string key, T data)
    {
        AddNode(key, data, _root);
    }
    
    public void AddNode(string key, T data, NodeTrie<T?> node)
    {
        if (string.IsNullOrEmpty(key))
        {
            if (!node.IsWord)
            {
                node.Data = data;
                node.IsWord = true;
            }
        }
        else
        {
            var symbol = key[0];
            var subnode = node.TryFind(symbol);
            if (subnode != null)
            {
                AddNode(key.Substring(1), data, subnode);
            }
            else
            {
                var newNode = new NodeTrie<T?>(key[0], data);
                node.SubNodes.Add(key[0], newNode);
                AddNode(key.Substring(1), data, subnode);
            }
        }
        
    }

    public void Remove(string key)
    {
        
    }

    public void Search(string key)
    {
        
    } 
}