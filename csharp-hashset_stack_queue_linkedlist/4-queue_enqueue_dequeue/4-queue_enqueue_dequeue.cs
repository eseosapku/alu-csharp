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

        Queue<string> tempQueue = new Queue<string>();

        bool containsSearch = false;
        
        // Dequeue and check each item
        while (aQueue.Count > 0)
        {
            string item = aQueue.Dequeue();
            tempQueue.Enqueue(item);
            if (item == search)
            {
                containsSearch = true;
                break;
            }
        }

        // Enqueue new item
        aQueue.Enqueue(newItem);

        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // Enqueue back items from tempQueue
        while (tempQueue.Count > 0)
        {
            string item = tempQueue.Dequeue();
            if (item != search)  // Skip the search item
            {
                aQueue.Enqueue(item);
            }
        }

        return aQueue;
    }
}
