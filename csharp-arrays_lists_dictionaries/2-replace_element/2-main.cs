using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        // Test ReplaceElement method
        int index = 2;
        int newValue = 10;
        arr = ArrayUtils.ReplaceElement(arr, index, newValue);

        Console.WriteLine($"Array after replacing element at index {index} with value {newValue}:");
        PrintArray(arr);
    }

    private static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
