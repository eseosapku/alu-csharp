class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square { Size = 12 };
        Console.WriteLine(mySquare is Shape ? "Square is a subclass of Shape" : "Square is NOT a subclass of Shape");
        Console.WriteLine($"Size: {mySquare.Size}");
    }
}
