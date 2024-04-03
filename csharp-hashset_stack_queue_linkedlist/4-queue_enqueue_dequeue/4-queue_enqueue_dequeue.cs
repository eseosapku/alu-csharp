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

        Queue<string> updatedQueue = new Queue<string>();

        // Process each item in the original queue
        bool foundSearch = false;
        while (aQueue.Count > 0)
        {
            string currentItem = aQueue.Dequeue();

            if (currentItem == search && !foundSearch)
            {
                // Skip printing and adding the search item back to the queue
                foundSearch = true;
            }
            else
            {
                updatedQueue.Enqueue(currentItem);
            }
        }

        // Add the new item if it's not already in the queue
        if (!containsSearch)
        {
            updatedQueue.Enqueue(newItem);
        }

        // Print the updated queue
        foreach (string item in updatedQueue)
        {
            Console.WriteLine(item);
        }

        // Return the updated queue
        return updatedQueue;
    }
}
