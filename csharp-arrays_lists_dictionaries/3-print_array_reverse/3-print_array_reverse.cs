using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null;
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        ReverseArray(array1);
        ReverseArray(array2); // This will produce a warning due to array2 being null
        ReverseArray(array3);
        ReverseArray(array4);
    }

    static void ReverseArray(int[] array)
    {
        Array.Reverse(array);
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
