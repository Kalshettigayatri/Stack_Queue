using System;
using System.Collections.Generic;

class StackOperations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stack Operations using LinkedList in C#");

        Stack<int> myStack = new Stack<int>();

        myStack.Push(56);
        myStack.Push(30);
        myStack.Push(70);

        Console.WriteLine("Peek: " + myStack.Peek()); // Peek without removing
        Console.WriteLine("Popping elements:");

        while (myStack.Count > 0)
        {
            Console.WriteLine(myStack.Pop()); // Pop and remove
        }
    }
}
