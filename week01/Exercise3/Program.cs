using System;

class Program
{
    static void Main(string[] args)
    {
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int numberOfGuesses = 0;

        // Loop until the user guesses the magic number
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();

            // Try to parse the user's input as an integer
            if (!int.TryParse(userInput, out guess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;  // Skip the rest of the loop and prompt for another guess
            }

            numberOfGuesses++;  // Increment the guess count

            // Provide feedback based on the guess
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {numberOfGuesses} guesses.");
            }
        }
    }
}
