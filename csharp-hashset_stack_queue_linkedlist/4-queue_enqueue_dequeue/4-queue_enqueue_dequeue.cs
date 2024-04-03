using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
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
class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }

        aQueue.Enqueue(newItem);

        bool containsSearch = aQueue.Contains(search);

        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        Queue<string> tempQueue = new Queue<string>();

        while (aQueue.Count > 0)
        {
            string item = aQueue.Dequeue();
            if (item == search && containsSearch)
            {
                break;
            }
            tempQueue.Enqueue(item);
        }

        while (tempQueue.Count > 0)
        {
            aQueue.Enqueue(tempQueue.Dequeue());
        }

        return aQueue;
    }
}
