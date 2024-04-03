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
        }
        else
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }

        aQueue.Enqueue(newItem);

        bool containsSearch = aQueue.Contains(search);

        if (containsSearch)
        {
            Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

            Queue<string> tempQueue = new Queue<string>();

            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue();
                if (item == search)
                {
                    break;
                }
                tempQueue.Enqueue(item);
            }

            // Add back elements that were not removed
            while (tempQueue.Count > 0)
            {
                aQueue.Enqueue(tempQueue.Dequeue());
            }
        }

        return aQueue;
    }
}
