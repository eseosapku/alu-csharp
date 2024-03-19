public class Line
{
    public static void PrintLine(int length)
    {
        // Check if length is 0 or less
        if (length <= 0)
        {
            Console.WriteLine(); // Print only a new line
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("_"); // Print "_" for the specified length
            }
            Console.WriteLine(); // End the line with a new line
        }
    }

    static void Main(string[] args)
    {
        // Example usage
        PrintLine(5);
        PrintLine(0);
        PrintLine(-3);
    }
}
