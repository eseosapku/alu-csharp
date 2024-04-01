using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        // Check if the index is out of range
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList; // Return the unchanged list
        }

        // Create a new list to store the updated elements
        List<int> updatedList = new List<int>();

        // Iterate through the original list and add elements to the updated list
        for (int i = 0; i < myList.Count; i++)
        {
            // Skip adding the element at the specified index
            if (i != index)
            {
                updatedList.Add(myList[i]);
            }
        }

        // Return the updated list
        return updatedList;
    }
}
