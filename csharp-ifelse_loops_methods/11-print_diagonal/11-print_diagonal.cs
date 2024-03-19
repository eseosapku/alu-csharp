using System;

public class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine(); 
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(new string(' ', i)); 
                Console.WriteLine("\\"); 
            }
        }
    }
    static void Main(string[] args)
    {
        PrintDiagonal(5);
        PrintDiagonal(0);
        PrintDiagonal(-3);
    }
}
