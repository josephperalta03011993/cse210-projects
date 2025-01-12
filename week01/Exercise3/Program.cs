using System;

class Program
{
    static void Main(string[] args)
    {
        // Loops
        /*
        C# provides four kinds of loops:
            while
            do-while
            for
            foreach
        */

        int magicNumber = new Random().Next(1, 100);
        int guess = 0;
        int attempts = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess > magicNumber) 
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        Console.WriteLine($"It took you {attempts} attempts to guess the magic number!");
        Console.WriteLine("Do you want to play again? (yes/no)");
        if (Console.ReadLine().ToLower() == "yes")
        {
            Main(args);
        }
        
    }
}