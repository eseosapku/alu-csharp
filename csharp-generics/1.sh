#!/usr/bin/env bash

# Create and enter the task directory
mkdir -p 1-enqueue
cd 1-enqueue

# Create the .csproj configured to match SDK 7.0 and route the XML documentation correctly
cat << 'EOF' > 1-enqueue.csproj
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <ImplicitUsings>disable</ImplicitUsings>
    <Nullable>disable</Nullable>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <DocumentationFile>bin\Debug\netcoreapp2.1\1-enqueue.xml</DocumentationFile>
  </PropertyGroup>

</Project>
EOF

# Create queue.cs with required public properties, methods, and nested Node class
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
    /// Returns the total count of elements currently in the Queue.
    /// </summary>
    /// <returns>The total number of nodes as an integer.</returns>
    public int Count()
    {
        return count;
    }
}
EOF

echo "Task 1 directory '1-enqueue' and its files created successfully."