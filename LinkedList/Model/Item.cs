namespace LinkedList.Model;

/// <summary>
/// Item
/// </summary>
/// <typeparam name="T"></typeparam>
public class Item<T>
{
    /// <summary>
    /// Data that saved in item enumerator 
    /// </summary>
    private T? val = default(T);

    public T? Value
    {
        get => val;
        set
        {
            if (value != null) val = value;
            else throw new ArgumentNullException(nameof(value));
        }
    }
    
    /// <summary>
    /// Next item
    /// </summary>

    public Item<T>? Next { get; set; }

    public Item(T value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}