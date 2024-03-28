using System;

public class PrintArrayReverse
{
    public static void PrintReversedArray(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Array is null");
            return;
        }

        Array.Reverse(array); // Reverse the non-null array
        foreach (int num in array)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine(); // Ensure output ends with a newline for correct formatting
    }
}
