using System;
using System.Collections.Generic;

public static class MyStack
{
    public static void Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        string topItem = null;
        if (aStack.Count > 0)
        {
            topItem = aStack.Peek();
            Console.WriteLine($"Top item: {topItem}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

        if (aStack.Contains(search))
        {
            Stack<string> tempStack = new Stack<string>();

            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    break;
                }
                else
                {
                    tempStack.Push(item);
                }
            }

            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        aStack.Push(newItem);
    }
}
