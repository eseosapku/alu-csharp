using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null;
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        PrintArrayReverse(array1);
        PrintArrayReverse(array2);
        PrintArrayReverse(array3);
        PrintArrayReverse(array4);
    }

    static void PrintArrayReverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine(); // Print an empty line for null or empty array
            return;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(); // Print a new line after printing the array
    }
}
