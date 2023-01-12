using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 100);

        Console.Write("Guess the MAGIC number between 1 and 100.");
        
        int guess = -1;
        int count = 1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            Console.WriteLine(" ");


            if (guess > magicNumber)
            {
                Console.WriteLine("Lower. ");

                Console.WriteLine(" ");

                count++;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher. ");

                Console.WriteLine(" ");

                count++;
            }
            else
            {
                Console.Write("You guessed it! It took you " + count + " tries. ");
            }
        }
        
        
    }
}