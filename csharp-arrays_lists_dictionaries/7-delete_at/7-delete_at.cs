
using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, List<int> indexesToDelete)
    {
        if (myList == null || indexesToDelete == null || indexesToDelete.Count == 0)
        {
            return myList; // Handle empty lists or empty index list
        }

        List<int> updatedList = new List<int>(myList.Count); // Pre-allocate size

        // Sort indexes in ascending order (important)
        indexesToDelete.Sort();

        int removedCount = 0; // Keeps track of elements already removed

        for (int i = 0; i < myList.Count; i++)
        {
            int currentIndex = i - removedCount; // Adjust index considering removals

            // Check for valid indexes and avoid out-of-range errors
            if (currentIndex < 0 || currentIndex >= myList.Count)
            {
                continue; // Skip invalid indexes
            }

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
