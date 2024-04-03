using System;
using System.Collections.Generic;

public class Dictionary
{
    // Note the use of string? to indicate the method can return null.
    public static string? BestScore(Dictionary<string, int> myList)
    {
        // Initial check to return "None" immediately if the dictionary is empty
        if (myList.Count == 0)
        {
            return "None";
        }

        // Initialize to keep track of the best score and key
        int highestScore = -1;
        string? bestKey = null;

        foreach (var kvp in myList)
        {
            if (kvp.Value > highestScore)
            {
                highestScore = kvp.Value;
                bestKey = kvp.Key; // Best key gets updated with the key having the highest score
            }
        }

        // If bestKey is null, it means no entries were found, return "None"
        return bestKey ?? "None";
    }
}
