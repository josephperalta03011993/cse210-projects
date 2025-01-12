using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();    
        string userName = PromptUserName();
        int userFavoriteNumber = PromptUserNumber();
        Console.WriteLine($"{userName}, the square of your number is {SquareNumber(userFavoriteNumber)}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
}