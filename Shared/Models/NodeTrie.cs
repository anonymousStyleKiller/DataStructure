namespace Shared.Models;

public class NodeTrie<T> 
{
    public char Symbol { get; set; }
    public T Data { get; set; }
    public bool IsWord { get; set; }
    public string Prefix { get; set; }
    public Dictionary<char, NodeTrie<T>?> SubNodes { get; set; }

    public NodeTrie(char symbol, T data)
    {
        Symbol = symbol;
        Data = data;
        SubNodes = new Dictionary<char, NodeTrie<T>?>();
    }
    
    public override string ToString()
    {
        return Data.ToString();
    }

    public override bool Equals(object? obj)
    {
        if (obj is NodeTrie<T> item)
        {
            return Data.Equals(item);
        }
        return false;
    }

    public NodeTrie<T> TryFind(char symbol)
    {
        if(SubNodes.TryGetValue(symbol, out NodeTrie<T> value))
        {
            return value;
        }
        else
        {
            return null;
        }
    }
}