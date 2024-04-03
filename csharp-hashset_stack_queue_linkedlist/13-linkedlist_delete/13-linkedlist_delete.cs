using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        // If the list is empty, return
        if (myLList.First == null)
        {
            return;
        }

        // If index is 0, delete the first node
        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        // Traverse the list to find the node at the given index
        LinkedListNode<int>? currentNode = myLList.First;
        int currentIndex = 0;
        while (currentNode != null && currentIndex < index - 1)
        {
            currentNode = currentNode.Next;
            currentIndex++;
        }

        // If the node at the given index doesn't exist, return
        if (currentNode == null || currentNode.Next == null)
        {
            return;
        }

        // Delete the node at the given index
        myLList.Remove(currentNode.Next);
    }
}
