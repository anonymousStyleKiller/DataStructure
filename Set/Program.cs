using Set.Implementations;

var set = new Set<int>
{
    5,
    5,
    5
};

foreach (var x in set)
{
    Console.WriteLine(x);
}