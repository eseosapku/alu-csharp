using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null; // This is explicitly null and will be handled gracefully.
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        PrintReversedArray(array1);
        PrintReversedArray(array2);
        PrintReversedArray(array3);
        PrintReversedArray(array4);
    }

    static void PrintReversedArray(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Array is null");
            return;
        }

        Array.Reverse(array); // Reverse the non-null array
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine(); // Ensure output ends with a newline for correct formatting
    }
}
