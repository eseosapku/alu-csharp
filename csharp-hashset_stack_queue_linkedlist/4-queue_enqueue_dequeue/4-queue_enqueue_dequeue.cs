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

        bool containsSearch = aQueue.Contains(search);

        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        if (!containsSearch)
        {
            Console.WriteLine("Search item not found, skipping the search item.");
        }

        // Rebuild the queue
        Queue<string> rebuiltQueue = new Queue<string>();
        foreach (var item in aQueue)
        {
            if (containsSearch && item == search)
            {
                break;
            }
            rebuiltQueue.Enqueue(item);
        }

        // Add new item if search item was found
        if (!containsSearch)
        {
            rebuiltQueue.Enqueue(newItem);
        }

        return rebuiltQueue;
    }
}
