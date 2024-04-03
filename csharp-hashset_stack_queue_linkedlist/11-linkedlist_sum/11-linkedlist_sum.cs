using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;

        // Iterate through each node in the linked list and add its value to the sum
        foreach (int value in myLList)
        {
            sum += value;
        }

        return sum;
    }
}
