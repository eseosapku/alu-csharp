using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, List<int> indexesToDelete)
    {
        List<int> updatedList = new List<int>();
        indexesToDelete.Sort(); // Sort indexes in ascending order (important)

        int removedCount = 0; // Keeps track of elements already removed

        for (int i = 0; i < myList.Count; i++)
        {
            int currentIndex = i - removedCount; // Adjust index considering removals

            if (indexesToDelete.Contains(currentIndex))
            {
                removedCount++; // Increment removed count if current index is to be deleted
                continue; // Skip adding element to updated list
            }

            updatedList.Add(myList[i]);
        }

        return updatedList;
    }
}

