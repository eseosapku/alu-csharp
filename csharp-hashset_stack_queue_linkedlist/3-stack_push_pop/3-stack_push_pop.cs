using System;
using System.Collections.Generic;

public static class MyStack
{
    public static void Info(Stack<string> stack, string newItem, string itemToCheck)
    {
        Console.WriteLine($"Number of items: {stack.Count}");
        
        if (stack.Count > 0)
            Console.WriteLine($"Top item: {stack.Peek()}");
        else
            Console.WriteLine("Stack is empty");

        Console.WriteLine($"Stack contains \"{itemToCheck}\": {stack.Contains(itemToCheck)}");

        stack.Pop();  // Remove the top item
        stack.Push(newItem);  // Add the new item to the top
    }
}
