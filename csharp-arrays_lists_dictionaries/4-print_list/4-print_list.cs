using System;
using System.Collections.Generic;

class ListUtils
{
    public static List<int>? CreatePrint(int size)
    {
        // Your implementation here
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int>? newList;

        newList = ListUtils.CreatePrint(10);
        if (newList != null)
        {
            Console.WriteLine("List Length: " + newList.Count);
            Console.WriteLine("----------------");
        }
        
        newList = ListUtils.CreatePrint(16);
        if (newList != null)
        {
            Console.WriteLine("List Length: " + newList.Count);
            Console.WriteLine("----------------");
        }
        
        newList = ListUtils.CreatePrint(0);
        if (newList != null)
        {
            Console.WriteLine("List Length: " + newList.Count);
            Console.WriteLine("----------------");
        }
        
        newList = ListUtils.CreatePrint(1);
        if (newList != null)
        {
            Console.WriteLine("List Length: " + newList.Count);
            Console.WriteLine("----------------");
        }        
    }
}
