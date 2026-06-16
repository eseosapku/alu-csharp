#!/usr/bin/env bash

# Create and enter the task directory
mkdir -p 5-concatenate
cd 5-concatenate

# Create the .csproj configured to match SDK 7.0 and route the XML documentation correctly
cat << 'EOF' > 5-concatenate.csproj
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <ImplicitUsings>disable</ImplicitUsings>
    <Nullable>disable</Nullable>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <DocumentationFile>bin\Debug\netcoreapp2.1\5-concatenate.xml</DocumentationFile>
  </PropertyGroup>

</Project>
EOF

# Create queue.cs with required properties, nested Node class, and corrected Concatenate string
cat << 'EOF' > queue.cs
using System;

/// <summary>
/// Represents a custom first-in, first-out generic collection.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>Represents the first node in the queue.</summary>
    public Node head { get; set; } = null;

    /// <summary>Represents the last node in the queue.</summary>
    public Node tail { get; set; } = null;

    /// <summary>Tracks the number of nodes currently in the queue.</summary>
    public int count { get; set; } = 0;

    /// <summary>
    /// Represents a node within the Queue.
    /// </summary>
    public class Node
    {
        /// <summary>Gets or sets the generic value stored within the node.</summary>
        public T value { get; set; } = default(T);

        /// <summary>Gets or sets the next node link reference.</summary>
        public Node next { get; set; } = null;

        /// <summary>
        /// Initializes a new instance of the Node class with a specified value.
        /// </summary>
        /// <param name="newValue">The value to store in the node.</param>
        public Node(T newValue)
        {
            value = newValue;
            next = null;
        }
    }

    /// <summary>
    /// Evaluates and returns the data type of the generic Queue.
    /// </summary>
    /// <returns>The Type of the generic parameter.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Creates a new Node and adds it to the end of the queue.
    /// </summary>
    /// <param name="value">The generic value to be added to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>
    /// Removes the first node in the queue and returns its value.
    /// </summary>
    /// <returns>The value of the removed node, or default(T) if empty.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T removedValue = head.value;
        head = head.next;

        if (head == null)
        {
            tail = null;
        }

        count--;
        return removedValue;
    }

    /// <summary>
    /// Looks at the value of the first node in the queue without removing it.
    /// </summary>
    /// <returns>The value of the head node, or default(T) if empty.</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    /// <summary>
    /// Prints the queue out to the console, starting from the head node.
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    /// <summary>
    /// Concatenates all values in the queue if the type is String or Char.
    /// </summary>
    /// <returns>The combined string representation of the elements, or null.</returns>
    public string Concatenate()
    {
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }

        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        string result = "";
        Node current = head;

        while (current != null)
        {
            if (typeof(T) == typeof(string))
            {
                result += current.value.ToString();
                if (current.next != null)
                {
                    result += " ";
                }
            }
            else if (typeof(T) == typeof(char))
            {
                result += current.value.ToString();
            }
            current = current.next;
        }

        return result;
    }

    /// <summary>
    /// Returns the total count of elements currently in the Queue.
    /// </summary>
    /// <returns>The total number of nodes as an integer.</returns>
    public int Count()
    {
        return count;
    }
}
EOF

echo "Task 5 directory configuration updated successfully."