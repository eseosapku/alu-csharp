using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };

        foreach (int i in myList)
            Console.WriteLine(i);

        Console.WriteLine("----------");

        myList = List.DeleteAt(myList, 2); // Assign the modified list back to myList

        foreach (int i in myList)
            Console.WriteLine(i);
    }
}

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList; // Return the unchanged list
        }

        List<int> updatedList = new List<int>(myList.Count - 1); // Pre-allocate size

        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                updatedList.Add(myList[i]);
            }
        }

        return updatedList;
    }
}
