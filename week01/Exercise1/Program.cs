using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first and last name
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        // Print the user's name
        Console.Write($"Your name is {lastname}, {firstname} {lastname}.");
    }
}