using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        // Create a new dictionary to store the results
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        // Iterate over each key-value pair in the original dictionary
        foreach (var pair in myDict)
        {
            // Multiply each value by 2 and add the result to the new dictionary
            newDict.Add(pair.Key, pair.Value * 2);
        }

        // Return the new dictionary
        return newDict;
    }
}
