using System;
using System.Collections.Generic;

class sixnumberslotto
{
    static void Main()
    {
        // Generate 6 unique winning numbers
        HashSet<int> winningNumbers = new HashSet<int>();
        Random random = new Random();
        while (winningNumbers.Count < 6)
        {
            winningNumbers.Add(random.Next(1, 46));
            // random numbers get selected between 1 - 45
        }

        HashSet<int> playerNumbers = new HashSet<int>();
        Console.WriteLine("=== Lotto Pick ===");
        Console.WriteLine("Pick 6 numbers between 1 and 45!");
        for (int i = 1; i <= 6; i++)
        {
            int num;
            while (true)
            {
                Console.Write($"Number {i}: ");
                if (int.TryParse(Console.ReadLine(), out num) &&
                    num >= 1 && num <= 45 && !playerNumbers.Contains(num))
                {
                    playerNumbers.Add(num);
                    break;
                }

                Console.WriteLine("Invalid input. Try again.");
            }
        }

        // Sort both sets for display
        var sortedWinning = winningNumbers.OrderBy(x => x).ToList();
        var sortedPlayer = playerNumbers.OrderBy(x => x).ToList();

        // Find matches
        var matches = sortedWinning.Intersect(sortedPlayer).ToList();

        // Display results
        Console.WriteLine($"The winning numbers are: {string.Join(", ", sortedWinning)}");
        Console.WriteLine($"Your numbers:           {string.Join(", ", sortedPlayer)}");
        Console.WriteLine($"You matched {matches.Count} numbers: {string.Join(", ", matches)}");
    }
}
    
    