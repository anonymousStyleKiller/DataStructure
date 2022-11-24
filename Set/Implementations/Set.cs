using System.Collections;

namespace Set.Implementations;

public class Set<T> : Interfaces.ISet<T>
{
    public List<T> items = new();
    public int Count => items.Count;

    public Set()
    {
        
    }
    public Set(IEnumerable<T> _items)
    {
        items = (List<T>)_items;
    }

    public Set(T item)
    {
        items.Add(item);
    }

    public void Add(T item)
    {
        if (items.Contains(item)) return;

        if (Enumerable.Contains(items, item))
        {
            return;
        }

        items.Add(item);
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

    public Set<T> Union(Set<T> set)
    {
        return new Set<T>(items.Union(set.items));
    }

    public Set<T> Intersection(Set<T> set)
    {
        return new Set<T>(items.Intersect(set.items));
    }

    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}