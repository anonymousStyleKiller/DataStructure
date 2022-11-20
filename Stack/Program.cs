

using Stack.Implementation;

var stack = new SimpleStack<int>();
stack.Push(1); 
stack.Push(10); 
stack.Push(4); 
stack.Push(5); 

var peekElement = stack.Peek();
var popElement = stack.Pop();
var peekElementAfterRemove = stack.Peek();

Console.WriteLine($"Peek element {peekElement}");
Console.WriteLine($"Remove element {peekElement}");
Console.WriteLine($"Peek element {peekElement} after remove");