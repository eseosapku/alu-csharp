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

        string firstItem = aQueue.Peek();
        Console.WriteLine($"First item: {firstItem}");

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        Queue<string> rebuiltQueue = new Queue<string>();
        bool foundSearchItem = false;
        
        // Dequeue and check each item
        while (aQueue.Count > 0)
        {
            string currentItem = aQueue.Dequeue();
            if (currentItem == search)
            {
                foundSearchItem = true;
                continue;
            }
            rebuiltQueue.Enqueue(currentItem);
        }

        // Rebuild the queue with the remaining items
        foreach (var item in rebuiltQueue)
        {
            aQueue.Enqueue(item);
        }

        // Add new item if search item was found
        if (!foundSearchItem)
        {
            aQueue.Enqueue(newItem);
        }

        return aQueue;
    }
}
