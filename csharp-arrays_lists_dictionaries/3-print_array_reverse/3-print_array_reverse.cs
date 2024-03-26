using System;

class Array {
    public static void Reverse(int[] array) {
        // Iterate through the array in reverse order
        for (int i = array.Length - 1; i >= 0; i--) {
            Console.WriteLine(array[i]); // Print each element
        }
    }

    // Example usage in the Main method (to test the Reverse method)
    public static void Main(string[] args) {
        int[] myArray = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original Array:");
        foreach (var item in myArray) {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Array in Reverse Order:");
        Reverse(myArray);
    }
}
