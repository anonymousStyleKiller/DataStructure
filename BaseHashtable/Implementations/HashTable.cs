using BaseHashtable.Interfaces;

namespace BaseHashtable.Implementations;

public class HashTable<T> :  IHashTable<T>
{
    private T[] items;

    public HashTable(int size)
    {
        items = new T[size];
    }

    public void Add(T item)
    {
        var key = GetHash(item);
        items[key] = item;
    }


    public bool Search(T item)
    {
        var key = GetHash(item);
        return Equals(items[key], item);
    }

    private int GetHash(T item) =>
        item.ToString().Length % items.Length;
}