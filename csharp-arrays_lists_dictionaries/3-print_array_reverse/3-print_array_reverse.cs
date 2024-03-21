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
        MyArray.Reverse(array2);
        MyArray.Reverse(array3);
        MyArray.Reverse(array4);
    }
}

class MyArray
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array; // Return the unchanged array
        }
        else
        {
            array[index] = n; // Replace the element at the specified index
            return array;
        }
    }

    public static void Reverse(int[] array)
    {
        if (array != null)
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
