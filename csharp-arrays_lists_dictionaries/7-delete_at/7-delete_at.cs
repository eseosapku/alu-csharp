using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, List<int> indexesToDelete)
    {
        // Check for null or empty lists
        if (myList == null || indexesToDelete == null || indexesToDelete.Count == 0)
        {
            return myList; // Return the original list if no modifications needed
        }

        List<int> updatedList = new List<int>(myList.Count); // Pre-allocate size

        // Sort indexesToDelete in ascending order (important)
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

            // Check if the current index is in the list of indexes to delete
            if (indexesToDelete.Contains(currentIndex))
            {
                removedCount++; // Increment removed count
                continue; // Skip adding element to updated list
            }

            updatedList.Add(myList[i]); // Add element to updated list
        }

        return updatedList;
    }
}
