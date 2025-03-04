using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101); // Generate random number between 1 and 100
            int guess = 0;
            int guessCount = 0;//variable for stretch challenge- keep track of how many guesses

            Console.WriteLine("Welcome to Guess My Number!");
            
            // repeat it until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                
                // check the input to ensure it's a number
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    guessCount++;//increase the guesscount

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {guessCount} tries.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            //Stretch Challenge- Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}