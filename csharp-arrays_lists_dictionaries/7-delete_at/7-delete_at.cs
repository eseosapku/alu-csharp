using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        List<int> updatedList = new List<int>();

        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList; // Return original list if index is invalid
        }

        // Iterate through original list, shifting elements after target
        for (int i = 0; i < myList.Count; i++)
        {
            if (i < index) // Add elements before target index
            {
                updatedList.Add(myList[i]);
            }
            else if (i > index) // Add elements after target index (shifted by 1)
            {
                updatedList.Add(myList[i - 1]);
            }
        }

        return updatedList;
    }
}
