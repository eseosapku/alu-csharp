using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // Check if the key already exists
        if (myDict.ContainsKey(key))
        {
            // Update the value if the key exists
            myDict[key] = value;
        }
        else
        {
            // Add the key-value pair if the key doesn't exist
            myDict.Add(key, value);
        }

        return myDict;
    }
}
