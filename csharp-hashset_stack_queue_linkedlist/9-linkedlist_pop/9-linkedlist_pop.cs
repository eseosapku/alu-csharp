using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.First == null)
        {
            // If the list is empty, return 0
            return 0;
        }

        // Get the value of the head node
        int value = myLList.First.Value;

        // Remove the head node
        myLList.RemoveFirst();

        return value;
    }
}
