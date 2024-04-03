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

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Mary", 14);
        myDict.Add("Molly", 16);

        newDict = Dictionary.MultiplyBy2(myDict);

        Console.WriteLine("Original dictionary:");
        foreach (KeyValuePair<string, int> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("--------------------");

        Console.WriteLine("New dictionary after multiplication:");
        foreach (KeyValuePair<string, int> entry in newDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
