using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // If the list is empty, return 0
        if (myLList.First == null)
        {
            return 0;
        }

        int currentIndex = 0;
        LinkedListNode<int> currentNode = myLList.First;

        // Traverse the list until the desired index or the end of the list is reached
        while (currentIndex < n && currentNode.Next != null)
        {
            currentNode = currentNode.Next;
            currentIndex++;
        }

        // If the desired index is greater than the number of nodes in the list, return 0
        if (currentIndex < n)
        {
            return 0;
        }

        // Return the value of the node at the given index
        return currentNode.Value;
    }
}
