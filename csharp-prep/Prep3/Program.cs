using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for magic number
        Console.Write("What is the magic number? ");

        // Read input
        int magicNumber = int.Parse(Console.ReadLine());

        // Declare guess outside the loop
        int guess;

        do
        {
            // Ask user for a guess
            Console.WriteLine("What is your guess? ");

            // Read input for guess
            guess = int.Parse(Console.ReadLine());

            // Conditional to see if user needs to guess higher or lower
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
                Console.WriteLine("You guessed it!");
            }
            
            // Loop until user gets the number right

        } while (magicNumber != guess);
    }
}