using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int index = 2;
        int newValue = 10;
        int[] updatedArray = Array.ReplaceElement(array, index, newValue);
        Console.WriteLine("Updated array: [{0}]", string.Join(", ", updatedArray));
    }
}

class Array
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
}
