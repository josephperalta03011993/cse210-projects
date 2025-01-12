using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 4
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
        int userInput = 1;

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        // Get the Sum
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"The sum is: {sum}");
    }
}