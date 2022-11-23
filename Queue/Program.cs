using Queue.Implementations;

var customQueue = new CustomQueue<int>();

customQueue.Enqueue(1);
customQueue.Enqueue(2);
customQueue.Enqueue(3);
customQueue.Enqueue(9);
customQueue.Enqueue(4);

Console.WriteLine(customQueue.Dequeue(1));
Console.WriteLine(customQueue.Peek());