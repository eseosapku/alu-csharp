using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null;
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        MyArray.Reverse(array1);
        MyArray.Reverse(array2); // This will produce a warning due to array2 being null
        MyArray.Reverse(array3);
        MyArray.Reverse(array4);
    }
}

class MyArray
{
    public static void Reverse(int[] array)
    {
        if (array != null) // Check for null reference before using the array
        {
            Array.Reverse(array);
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Array is null");
        }
    }
}
