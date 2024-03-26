using System;

class Array {
    public static void Reverse(int[] array) {
        if (array == null) {
            Console.WriteLine();
            return;
        }

        int size = array.Length;
        if (size > 0) {
            for (int i = size - 1; i >= 0; i--) {
                Console.Write(array[i]);
                if (i != 0) // Add space if it's not the first number
                    Console.Write(" ");
            }
            Console.WriteLine();
        } else {
            Console.WriteLine();
        }
    }
}
