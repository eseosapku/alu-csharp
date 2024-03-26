using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null;
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        Array.Reverse(array1);
        if (array2 != null) // Check if array2 is not null before calling Reverse
            Array.Reverse(array2);
        if (array3 != null) // Check if array3 is not null before calling Reverse
            Array.Reverse(array3);
        Array.Reverse(array4);

        // Print the reversed arrays
        Console.WriteLine("Reversed array1:");
        PrintArray(array1);

        Console.WriteLine("Reversed array2:");
        PrintArray(array2);

        Console.WriteLine("Reversed array3:");
        PrintArray(array3);

        Console.WriteLine("Reversed array4:");
        PrintArray(array4);
    }

    static void PrintArray(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Array is null");
            return;
        }
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
