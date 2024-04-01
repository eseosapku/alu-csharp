using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList == null)
        {
            Console.WriteLine("List is null");
            return myList;
        }

        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        myList.RemoveAt(index);
        return myList;
    }
}
