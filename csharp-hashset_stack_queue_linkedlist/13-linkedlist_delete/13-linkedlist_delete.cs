using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList.First == null || index < 0)
        {
            return; // No elements in the list or invalid index, do nothing
        }

        if (index == 0)
        {
            myLList.RemoveFirst(); // Remove the first node if index is 0
            return;
        }

        LinkedListNode<int> previousNode = myLList.First;
        LinkedListNode<int>? currentNode = previousNode.Next;

        // Traverse the list until the desired index or the end of the list is reached
        for (int i = 1; i < index && currentNode != null; i++)
        {
            previousNode = currentNode;
            currentNode = currentNode.Next;
        }

        // If the current node is null, index is out of range
        if (currentNode == null)
        {
            return;
        }

        // Remove the node at the given index
        myLList.Remove(currentNode);
    }
}
