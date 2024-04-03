using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        string bestKey = null;
        int maxValue = int.MinValue;

        foreach (var pair in myList)
        {
            if (pair.Value > maxValue)
            {
                maxValue = pair.Value;
                bestKey = pair.Key;
            }
        }

        return bestKey ?? "None";
    }
}
