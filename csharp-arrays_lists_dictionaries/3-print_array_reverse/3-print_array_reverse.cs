using System;

public class Array
{
  public static void Reverse(int[] array)
  {
    // Loop through the array in reverse order
    for (int i = array.Length - 1; i >= 0; i--)
    {
      // Print the element at the current index
      Console.Write(array[i] + " ");
    }
    Console.WriteLine(); // Add a newline at the end for better formatting
  }
}
