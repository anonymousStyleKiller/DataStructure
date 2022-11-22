// See https://aka.ms/new-console-template for more information

using DoubleLinkedList.Implementations;

var doubleList = new DoubleLinkedList<int>(3);
doubleList.Add(1);
doubleList.Add(7);
doubleList.Add(4);
doubleList.Add(1);


foreach (var item in doubleList)
{
    Console.WriteLine(item);
}

Console.WriteLine(new string('-', 50));

doubleList.Remove(4);

foreach (var item in doubleList)
{
    Console.WriteLine(item);
}

Console.WriteLine(new string('-', 50));

var reverse = doubleList.Reverse();
foreach (var item in reverse)
{
    Console.WriteLine(item);
}