﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int>? CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> newList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i + " ");
        }

        Console.WriteLine(); // Print new line after printing the list

        return newList; // Return the newly created list
    }
}
