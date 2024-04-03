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

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        Dictionary.PrintSorted(myDict);
    }
}
