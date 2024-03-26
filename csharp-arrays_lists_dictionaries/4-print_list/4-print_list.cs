using System;
using System.Collections.Generic;

class ListUtils
{
    public static List<int>? CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> newList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i + " ");
        }

        Console.WriteLine(); // Print new line after printing the list

        return newList;
    }

    // Example usage in the Main method (to test the CreatePrint method)
    static void Main(string[] args)
    {
        int size = 10;
        List<int>? newList = CreatePrint(size);

        // Example usage of the created list
        if (newList != null)
        {
            Console.WriteLine("Created List:");
            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); // Print new line after printing the list
        }
    }
}
