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

class Program
{
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}
