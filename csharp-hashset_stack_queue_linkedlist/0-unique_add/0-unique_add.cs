using System;
using System.Collections.Generic;

public class List
{
    public static int Sum(List<int> myList)
    {
        // Create a HashSet to store unique integers
        HashSet<int> uniqueIntegers = new HashSet<int>();

        // Iterate through the list and add unique integers to the HashSet
        foreach (int num in myList)
        {
            if (!uniqueIntegers.Contains(num))
            {
                uniqueIntegers.Add(num);
            }
        }

        // Calculate the sum of unique integers
        int sum = 0;
        foreach (int num in uniqueIntegers)
        {
            sum += num;
        }

        return sum;
    }
}
