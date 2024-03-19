// See https://aka.ms/new-console-template for more information
public class Character
{
    public static bool IsLower(char c)
    {
        return c >= 'a' && c <= 'z';
    }

    static void Main(string[] args)
    {
        // Example usage
        char ch1 = 'a';
        char ch2 = 'B';
        Console.WriteLine($"{ch1} is lowercase: {IsLower(ch1)}");
        Console.WriteLine($"{ch2} is lowercase: {IsLower(ch2)}");
    }
}

