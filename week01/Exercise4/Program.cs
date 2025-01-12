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

        // Get the averate
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Get the largest
        int max = numbers[0];
        foreach (int item in numbers)
        {
            if (item > max)
            {
                max = item;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Get the smallest positive number
        int min = numbers[0];
        foreach (int item in numbers)
        {
            if (item < min && item > 0)
            {
                min = item;
            }
        }
        Console.WriteLine($"The smallest positive number is: {min}");

        // Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int item in numbers)
        {
            Console.WriteLine($"{item} ");
        }
    }
}