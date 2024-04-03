using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int>? Insert(LinkedList<int> myLList, int n)
    {
        // If the list is empty or n is less than the first node's value, insert at the beginning
        if (myLList.First == null || n < myLList.First.Value)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }

        // Traverse the list to find the correct position to insert the new node
        LinkedListNode<int>? currentNode = myLList.First;
        while (currentNode.Next != null && currentNode.Next.Value < n)
        {
            currentNode = currentNode.Next;
        }

        // Insert the new node after currentNode
        LinkedListNode<int> newNode = myLList.AddAfter(currentNode, n);
        return newNode;
    }
}

