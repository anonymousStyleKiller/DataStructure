using Shared.Models;

namespace BaseDictionary.Implementations;

public class BaseDictionary<TKey, TValue>
{
    private List<DictionaryItem<TKey, TValue>> Items = new();
    private List<TKey> Keys = new(); 

    public BaseDictionary()
    {
        
    }

    public void Add(DictionaryItem<TKey, TValue> item)
    {
        if (!Keys.Contains(item.Key))
        {
            Items.Add(item);
        }
    }
    
    public object Search(TKey item)
    {
        if (Keys.Contains(item))
        {
            return  Items.Single(i=>i.Key.Equals(item)).Value;
        }

        return null;
    }
}