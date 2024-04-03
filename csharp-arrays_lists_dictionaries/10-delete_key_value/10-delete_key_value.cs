using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        // Check if the key exists in the dictionary
        if (myDict.ContainsKey(key))
        {
            // If the key exists, remove the key-value pair
            myDict.Remove(key);
        }

        // Return the updated dictionary
        return myDict;
    }
}
