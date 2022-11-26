using BaseHashtable.Implementations;

var badHashTable = new HashTable<int>(100);
badHashTable.Add(5);
badHashTable.Add(12);
badHashTable.Add(700);

Console.WriteLine(badHashTable.Search(5));
Console.WriteLine(badHashTable.Search(77));