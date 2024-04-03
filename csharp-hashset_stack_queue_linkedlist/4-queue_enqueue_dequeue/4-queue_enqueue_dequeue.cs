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

        while (aQueue.Count > 0)
        {
            string item = aQueue.Dequeue();
            if (item == search)
            {
                containsSearch = true;
                break;
            }
            tempQueue.Enqueue(item);
        }

        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        while (tempQueue.Count > 0)
        {
            aQueue.Enqueue(tempQueue.Dequeue());
        }

        return aQueue;
    }
}
