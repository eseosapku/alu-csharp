using System;

class Program
{
    static void Main(string[] args)
    {
        string alphabet = ""; // Initialize an empty string to store the alphabet
        
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (letter != 'q' && letter != 'e') // Exclude 'q' and 'e'
            {
                alphabet += letter; // Concatenate each desired letter to the string
            }
        }

        Console.Write(alphabet); // Print the desired alphabet without a new line
    }
}
