namespace BaseHashtable.Interfaces;

public interface IHashTable<T>
{
    public void Add(T item);
    public bool Search(T item);
    
}