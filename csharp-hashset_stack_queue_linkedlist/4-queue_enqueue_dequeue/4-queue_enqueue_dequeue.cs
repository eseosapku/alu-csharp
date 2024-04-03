using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return aQueue;
        }

        Console.WriteLine($"First item: {aQueue.Peek()}");
        aQueue.Enqueue(newItem);

        bool containsSearch = false;
        int count = aQueue.Count;
        for (int i = 0; i < count; i++)
        {
            string item = aQueue.Dequeue();
            if (containsSearch || item != search)
            {
                aQueue.Enqueue(item);
            }
            else
            {
                containsSearch = true;
            }
        }

        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        return aQueue;
    }
}
