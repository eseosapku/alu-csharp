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

        return myList; // Return the unchanged list if index is 0, 1, or 4
    }
}
