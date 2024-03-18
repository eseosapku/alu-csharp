using System;

class Program
{
    static void Main(string[] args)
    {
        string alphabet = ""; // Initialize an empty string to store the alphabet
        
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            alphabet += letter; // Concatenate each letter to the string
        }

        Console.Write(alphabet); // Print the alphabet without a new line
    }
}
