using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = aQueue.Count;
        bool found = false;

        Console.WriteLine($"Number of items: {count}");

        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }

        while (count > 0)
        {
            string item = aQueue.Dequeue();
            count--;

            if (item == search)
            {
                found = true;
                break;
            }
        }

        aQueue.Enqueue(newItem);

        Console.WriteLine($"Queue contains \"{search}\": {found}");

        // Add the dequeued elements back to the queue
        foreach (string item in aQueue)
        {
            aQueue.Enqueue(item);
        }

        // Clear the elements that were previously dequeued
        for (int i = 0; i < count; i++)
        {
            aQueue.Dequeue();
        }

        return aQueue;
    }
}
