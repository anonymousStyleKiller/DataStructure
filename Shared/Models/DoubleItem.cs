namespace Shared.Models;

public class DoubleItem<T>
{
    public T Data { get; set; }
    public DoubleItem<T> Prev { get; set; }
    public DoubleItem<T> Next { get; set; }
    

    public DoubleItem(T data)
    {
        Data = data;
    }

    public override string ToString()
    {
        return Data.ToString();
    }
}