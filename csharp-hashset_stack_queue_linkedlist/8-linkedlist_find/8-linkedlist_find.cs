using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        LinkedListNode<int> current = myLList.First;

        // Iterate through the linked list
        while (current != null)
        {
            // If the current node's value matches the target value, return its index
            if (current.Value == value)
            {
                return index;
            }

            // Move to the next node
            current = current.Next;
            index++;
        }

        // If the value is not found, return -1
        return -1;
    }
}
