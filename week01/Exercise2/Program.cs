using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Core Requirements
            1. Ask the user for their grade percentage, then write a series of if, else if, else statements to print out the appropriate 
                letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)
            2. Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. 
                Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. 
                If not, display a different message to encourage them for next time.
            3. Change your code from the first part, so that instead of printing the letter grade in the body of each if, else if, or 
                else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. 
                Finally, after the whole series of if, else if, else statements, have a single print statement that prints the letter grade once.
        */

        // Ask the user for their grade percentage, 
        Console.Write("Enter your grade percentage: ");
        // then write a series of if, else if, else statements to print out the appropriate letter grade. 
        // (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90) 
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Please input a valid grade.");
        }

        // Add sign + and - to the letter grade
        int checkRemainder = grade % 10;
        
        if (checkRemainder >= 7)
        {   
            // Recognize that there is no A+ grade, only A and A-. 
            // Add some additional logic to your program to detect this case and handle it correctly.
            if (letter != "A" && letter != "F")
            {
                letter += "+";
            }
        }
        else if (checkRemainder <= 3)
        {
            if (letter != "F") 
            {
                letter += "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}");

        // Assume that you must have at least a 70 to pass the class.
        if (grade >= 70) {
            Console.WriteLine("Congratulations! You passed the class.");
        } 
        else 
        {
            Console.WriteLine("Sorry you failed the class, but this is a great learning experience for you. Keep going and try again next time.");
        }
    }
}