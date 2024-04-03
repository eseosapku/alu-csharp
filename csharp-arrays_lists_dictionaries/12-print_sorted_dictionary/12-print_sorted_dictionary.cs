using System;
using System.Collections.Generic;
using System.Linq;

public class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        // Sort the keys of the dictionary
        var sortedKeys = myDict.Keys.OrderBy(key => key);

        // Print the key-value pairs in sorted order
        foreach (var key in sortedKeys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
