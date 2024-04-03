using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (myLList == null || myLList.First == null)
        {
            // If the linked list is null or empty, return -1
            return -1;
        }

        LinkedListNode<int> current = myLList.First;

        int index = 0;
        while (current != null)
        {
            if (current.Value == value)
            {
                // Return the index of the node if the value is found
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
