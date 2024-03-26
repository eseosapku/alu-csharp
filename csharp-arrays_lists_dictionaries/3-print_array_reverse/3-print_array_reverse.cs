using System;

class Array
{
  public static void Reverse(int[] array)
  {
    // Check for null array
    if (array == null)
    {
      Console.WriteLine("Array is null");
      return;  // Exit the method if the array is null
    }

    // Loop through the array in reverse order
    for (int i = array.Length - 1; i >= 0; i--)
    {
      Console.Write(array[i] + " ");
    }
    Console.WriteLine(); // Add a newline for better formatting
  }
}
