using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5]; // Create a 5x5 array

        // Initialize all elements to 0
        // This step is technically not needed in C# as integers are initialized to 0 by default,
        // but it's here for clarity and to explicitly match the requirement.
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
            }
        }

        // Set index [2,2] to 1
        array[2, 2] = 1;

        // Print the array
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]);
                if (j < array.GetLength(1) - 1) Console.Write(" "); // Add space between numbers, but not at the end
            }
            Console.WriteLine(); // Move to the next line after printing each row
        }
    }
}
