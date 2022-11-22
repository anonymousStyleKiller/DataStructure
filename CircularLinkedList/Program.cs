using CircularLinkedList.Implementations;

var circularLL = new CircularLinkedList<int>(4);
circularLL.Add(5);
circularLL.Add(7);
circularLL.Add(8);

foreach (var item in circularLL)
{
    Console.WriteLine(item);
}



Console.WriteLine(new string('-', 50));

circularLL.Remove(7);


foreach (var item in circularLL)
{
    Console.WriteLine(item);
}


