﻿using SystemCollections;

class Array {
    public static void Reverse(int[] array) {
        if (array != null) {
            int size = array.Length;
            if (size > 0) {
                for (int i = size - 1; i >= 0; i--) {
                    Console.Write(array[i]);
                    if (i != 0) 
                        Console.Write(" ");
                }
                Console.WriteLine();
            } else {
                Console.WriteLine();
            }
        } else {
            Console.WriteLine();
        }
   
   
    
    }
}
