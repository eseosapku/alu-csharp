public class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        Console.WriteLine("Last digit of {0} is {1}", number, lastDigit);
        return lastDigit;
    }

    static void Main(string[] args)
    {
        int num1 = 12345;
        int num2 = -9876;
        PrintLastDigit(num1);
        PrintLastDigit(num2);
    }
}

