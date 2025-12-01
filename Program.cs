using System;
using System.Collections.Generic;
using System.Linq;

class LottoGame
{
    static void Main()
    {
        // Generate 6 unique winning numbers
        List<int> winningNumbers = new List<int>();
        Random random = new Random();
        while (winningNumbers.Count < 6)
        {
            int num = random.Next(1, 46);
            if (!winningNumbers.Contains(num))
                winningNumbers.Add(num);
        }

        // Let the player pick 6 unique numbers
        List<int> playerNumbers = new List<int>();
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

        // Sort both lists for display
        var sortedWinning = winningNumbers.OrderBy(x => x).ToList();
        var sortedPlayer = playerNumbers.OrderBy(x => x).ToList();

        // Find matches using Intersect
        var matches = sortedWinning.Intersect(sortedPlayer).ToList();

        // Display results
        Console.WriteLine($"The winning numbers are: {string.Join(", ", sortedWinning)}");
        Console.WriteLine($"Your numbers:           {string.Join(", ", sortedPlayer)}");
        Console.WriteLine($"You matched {matches.Count} numbers: {string.Join(", ", matches)}");
    }
}