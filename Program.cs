using System;
using System.Collections.Generic;

class QueueUsingLinkedList<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void Enqueue(T value)
    {
        // Enqueue the value at the end of the queue
        list.AddLast(value);
    }

    public T Dequeue()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T value = list.First.Value;
        list.RemoveFirst();
        return value;
    }

    public T Peek()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return list.First.Value;
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();

        // Enqueue values into the queue
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);

        // Dequeue and peek until the queue is empty
        while (!queue.IsEmpty())
        {
            Console.WriteLine("Front of the queue: " + queue.Peek());
            Console.WriteLine("Dequeued value: " + queue.Dequeue());
        }
    }
}