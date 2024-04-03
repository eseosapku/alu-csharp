using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // Sort both lists
        list1.Sort();
        list2.Sort();

        List<int> differentElements = new List<int>();

        int i = 0;
        int j = 0;

        // Traverse both lists
        while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] == list2[j])
            {
                i++;
                j++;
            }
            else if (list1[i] < list2[j])
            {
                differentElements.Add(list1[i]);
                i++;
            }
            else
            {
                differentElements.Add(list2[j]);
                j++;
            }
        }

        // Add remaining elements from list1
        while (i < list1.Count)
        {
            differentElements.Add(list1[i]);
            i++;
        }

        // Add remaining elements from list2
        while (j < list2.Count)
        {
            differentElements.Add(list2[j]);
            j++;
        }

        return differentElements;
    }
}
