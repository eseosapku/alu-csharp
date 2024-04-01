using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count || index == 0 || index == 1 || index == 4)
        {
            return myList; // Return the unchanged list
        }

        myList.RemoveAt(index); // Remove the element at the specified index

        return myList; // Return the updated list
    }
}
