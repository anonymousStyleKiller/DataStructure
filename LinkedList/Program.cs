

var list = new LinkedList.Model.LinkedList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);

foreach (var i in list)
{
    Console.Write(i + " ");
}

Console.WriteLine();

list.Remove(1);
list.Remove(2);
list.Remove(7);

foreach (var i in list)
{
    Console.Write(i + " ");
}

Console.WriteLine();