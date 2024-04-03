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

        // Create a temporary queue to store items
        Queue<string> tempQueue = new Queue<string>();

        // Dequeue all items and check for search item
        while (aQueue.Count > 0)
        {
            string currentItem = aQueue.Dequeue();
            if (currentItem != search)
            {
                tempQueue.Enqueue(currentItem);
            }
        }

        // If search item not found, add new item
        if (!containsSearch)
        {
            aQueue.Enqueue(newItem);
        }

        // Re-enqueue items from temporary queue
        while (tempQueue.Count > 0)
        {
            aQueue.Enqueue(tempQueue.Dequeue());
        }

        return aQueue;
    }
}
