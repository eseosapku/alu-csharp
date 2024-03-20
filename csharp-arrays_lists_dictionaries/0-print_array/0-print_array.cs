using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            Console.WriteLine();
            return new int[0]; // Return an empty array
        }
        else
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = i;
                Console.Write($"{i} ");
            }
            Console.WriteLine(); // Print new line after printing all elements
            return newArray;
        }
    }

    // Example usage
    static void Main(string[] args)
    {
        CreatePrint(5);
        CreatePrint(0);
        CreatePrint(-3);
    }
}
