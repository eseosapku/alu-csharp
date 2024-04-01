using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList; // Return the unchanged list
        }

        if (index != 0 && index != 1 && index != 4)
        {
            myList.RemoveAt(index);
        }

        return myList; // Return the list with or without deletion based on the condition
    }
}
