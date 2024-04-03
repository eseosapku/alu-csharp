using System.Collections;

class MyQueue
{
 public static Queue<string> Info(Queue<string> aQueue, string newItem, string search){
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if(aQueue.Count == 0){
            Console.WriteLine("Queue is empty");
        }else{
             Console.WriteLine($"First item: {aQueue.Peek()}");
        }

        aQueue.Enqueue(newItem);

        if(aQueue.Contains(search)){
            Console.WriteLine($"Queue contains \"{search}\": True");
        }

	  bool containsSearch = false;
        int count = aQueue.Count;
        for (int i = 0; i < count; i++)
        {
            string item = aQueue.Dequeue();
            if (containsSearch)
            {
                aQueue.Enqueue(item);
            }
            else if (item == search)
            {
                containsSearch = true;
            }
        }

        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        return aQueue;
    }
}
