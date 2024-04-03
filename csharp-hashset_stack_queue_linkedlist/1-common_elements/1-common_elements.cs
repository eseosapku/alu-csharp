﻿using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // Sort both lists
        list1.Sort();
        list2.Sort();

        List<int> commonElements = new List<int>();

        int i = 0;
        int j = 0;

        // Traverse both lists
        while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] == list2[j])
            {
                commonElements.Add(list1[i]);
                i++;
                j++;
            }
            else if (list1[i] < list2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return commonElements;
    }
}
