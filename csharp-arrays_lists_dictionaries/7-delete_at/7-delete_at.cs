using System;
using System.Collections.Generic;

class ListOperations
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= 0 && index < myList.Count)
        {
            myList.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Index is out of range");
        }

        return myList;
    }
}
