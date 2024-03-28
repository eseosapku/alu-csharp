using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= 0 && index < myList.Count)
        {
            List<int> updatedList = new List<int>();
            for (int i = 0; i < myList.Count; i++)
            {
                if (i != index)
                {
                    updatedList.Add(myList[i]);
                }
            }
            return updatedList;
        }
        else
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };

        foreach (int i in myList)
            Console.WriteLine(i);

        Console.WriteLine("----------");

        myList = List.DeleteAt(myList, 1);

        foreach (int i in myList)
            Console.WriteLine(i);
    }
}
