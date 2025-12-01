using System;
using System.Collections.Generic;

class Guessnumbers
{
    static void Main()
    {
        Random random = new Random();
        int goalNumber = random.Next(1, 101);
        List<int> guesses = new List<int>();
        ////  List<int> or int[] selection : List<int> is dynamic in size and can grow or shrink as needed. /////

        Console.WriteLine("Welcome to Guess the Number!");
        Console.WriteLine("I'm thinking of a number between 1 and 100...");

        while (true)
        {
            Console.Write("Your guess: ");
            int guess = int.Parse(Console.ReadLine());
            guesses.Add(guess);

            if (guess < goalNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > goalNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Correct!");
                break;
            }
        }

        Console.WriteLine($"You found it in {guesses.Count} guesses: {string.Join(", ", guesses)}");
    }
}