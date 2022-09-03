using System;

namespace ProgChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            bool keepGoing = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guessNum = 0;
            int guessCount = 0;

            // Use a do-while loop because we know we want it to execute at least once
            do {
                // Ask the user for their current guess
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();

                // Use the TryParse method to parse the input into a number
                bool result = Int32.TryParse(theGuess, out guessNum);

                // If the user entered something other than a number ask them again
                if (!result) {
                    Console.WriteLine("Hmmm, that doesn't look like a number. Try again.");
                }
                else {
                    // If they enter a -1 then they want to exit the game
                    if (guessNum == -1) {
                        Console.WriteLine($"Oh well. I was thinking of {theNumber}");
                        keepGoing = false;
                    }
                    else {
                        // Increase the guess count
                        guessCount++;

                        // If they got it right, tell them the guess count and exit
                        if (guessNum == theNumber) {
                            Console.WriteLine($"You got it in {guessCount} guesses!!");
                            keepGoing = false;
                        }
                        else {
                            // Tell them to either guess lower or higher than the previous guess
                            Console.WriteLine("Nope, {0} than that.", guessNum < theNumber ? "higher" : "lower");
                        }
                    }
                }
            } while(keepGoing);
        }
    }
}
