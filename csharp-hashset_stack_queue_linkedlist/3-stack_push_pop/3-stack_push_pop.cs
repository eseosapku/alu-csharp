using System;
using System.Collections.Generic;

public static class MyStack
{
    public static void Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine("Stack is empty");

        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

        if (aStack.Contains(search))
        {
            Stack<string> tempStack = new Stack<string>();
            bool found = false;

            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    found = true;
                    break;
                }
                else
                {
                    tempStack.Push(item);
                }
            }

            if (!found)
            {
                while (tempStack.Count > 0)
                {
                    aStack.Push(tempStack.Pop());
                }
            }
        }

        aStack.Push(newItem);
    }
}
