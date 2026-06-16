using System;

/// <summary>
/// Represents a custom first-in, first-out generic collection.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Gets the type of the generic Queue.
    /// </summary>
    /// <returns>The Type of the generic parameter.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
