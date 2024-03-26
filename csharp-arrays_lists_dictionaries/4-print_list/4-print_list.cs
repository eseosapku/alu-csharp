using System;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint(int size){
        List<int> myList = new List<int>();

        if (size == 0 || size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else{
            for (int i = 0; i < size; i++){
                myList.Add(i);
            }
            PrintList(myList);
            return myList;
        }
    }

    static void PrintList(List<int> list)
    {
        Console.Write("List: ");
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Main method can be left empty
    }
}
