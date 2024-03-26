using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList;

        myList = List.CreatePrint(10);
        PrintList(myList);

        myList = List.CreatePrint(16);
        PrintList(myList);

        myList = List.CreatePrint(0);
        PrintList(myList);

        myList = List.CreatePrint(1);
        PrintList(myList);
    }

    static void PrintList(List<int> list)
    {
        if (list != null)
        {
            Console.Write("List: ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("List is null");
        }
    }
}

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size <= 0)
        {
            Console.WriteLine("Size cannot be zero or negative. Returning an empty list.");
            return new List<int>();
        }

        List<int> myList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            myList.Add(i);
        }

        return myList;
    }
}
