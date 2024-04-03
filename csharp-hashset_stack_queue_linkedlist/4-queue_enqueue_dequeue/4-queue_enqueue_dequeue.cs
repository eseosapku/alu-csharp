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
        Queue<string> tempQueue = new Queue<string>();

        // Process each item in the original queue
        while (aQueue.Count > 0)
        {
            string currentItem = aQueue.Dequeue();

            // Check if the current item matches the search item
            if (currentItem == search)
            {
                containsSearch = true;
                break; // Stop processing further
            }

            // Otherwise, enqueue the item to the temporary queue
            tempQueue.Enqueue(currentItem);
        }

        // Enqueue the remaining items back to the original queue
        while (tempQueue.Count > 0)
        {
            aQueue.Enqueue(tempQueue.Dequeue());
        }

        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        return aQueue;
    }
}
