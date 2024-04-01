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

        List<int> updatedList = new List<int>();
        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                updatedList.Add(myList[i]);
            }
        }

        return updatedList; // Return the updated list
    }
}
