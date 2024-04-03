using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newList = new LinkedList<int>();

        if (size <= 0)
        {
            return newList; // Return an empty list for negative or zero size
        }

        // Add elements to the list and print them
        for (int i = 0; i < size; i++)
        {
            newList.AddLast(i);
            Console.WriteLine(i);
        }

        return newList;
    }
}

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> llist;
        int size = 8;

        llist = LList.CreatePrint(size);

        Console.WriteLine("-------------");
        Console.WriteLine("Linked List Length: " + llist.Count);
    }
}
