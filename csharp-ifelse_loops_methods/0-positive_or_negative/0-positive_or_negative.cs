// See https://aka.ms/new-console-template for more information
Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        Console.Write("The number {0} ", number);
        if (number > 0)
        {
            Console.WriteLine("is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine("is zero");
        }
        else
        {
            Console.WriteLine("is negative");
        }
