using System;
using System.Collections.Generic;

public static class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count > 0)
            Console.WriteLine($"First item: {aQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");

        aQueue.Enqueue(newItem);

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            while (aQueue.Count > 0 && aQueue.Peek() != search)
            {
                aQueue.Dequeue();
            }
            if (aQueue.Count > 0)
                aQueue.Dequeue(); // Remove the item containing the search string
        }

        return aQueue;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<string> aQueue = new Queue<string>();

        aQueue.Enqueue("C");
        aQueue.Enqueue("HTML");
        aQueue.Enqueue("Javascript");
        aQueue.Enqueue("Python");
        aQueue.Enqueue("React");
        aQueue.Enqueue("Ruby");

        foreach (string item in aQueue)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyQueue.Info(aQueue, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aQueue)
            Console.WriteLine(item);
    }
}

