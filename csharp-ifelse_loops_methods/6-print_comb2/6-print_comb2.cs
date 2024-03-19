// See https://aka.ms/new-console-template for more information
int count = 0; // Variable to count how many combinations are printed

        for (int i = 0; i <= 9; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                Console.Write($"{i}{j:D}");
                count++;

                if (count < 45) // Check if it's not the last combination
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine(); // Print new line after the last combination
                }
            }
        }
