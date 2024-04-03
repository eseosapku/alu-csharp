using System;
using System.Collections.Generic;

class MyQueue
{
    public static void Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        string firstItem = aQueue.Peek();
        Console.WriteLine($"First item: {firstItem}");

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // Create a temporary queue to hold the updated items
        Queue<string> updatedQueue = new Queue<string>();

        // Process each item in the original queue
        while (aQueue.Count > 0)
        {
            string currentItem = aQueue.Dequeue();

            // If the current item matches the search and it's the first occurrence
            if (currentItem == search && containsSearch)
            {
                // Skip adding the search item back to the queue
                containsSearch = false;
            }
            else
            {
                // Otherwise, add the current item to the updated queue
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
            // Add the item back to the original queue
            aQueue.Enqueue(item);
        }
    }
}
