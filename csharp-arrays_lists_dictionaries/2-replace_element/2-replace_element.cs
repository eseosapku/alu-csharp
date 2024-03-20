using System;

public class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        else
        {
            return array[index];
        }
    }

    // Example usage
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine(elementAt(arr, 2)); // Should print 3
        Console.WriteLine(elementAt(arr, 7)); // Should print "Index out of range" and return -1
    }
}

