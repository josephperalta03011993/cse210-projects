using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Journal journal = new Journal();

        while(userChoice != 6)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save as .txt");
            Console.WriteLine("5. Save as .csv");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            // Accept user input
            userChoice = int.Parse(Console.ReadLine());
            // Check user input
            if(userChoice == 1)
            {
                // Show prompt and ask for user response
                PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{randomPrompt} ");
                Console.Write("> ");
                string myEntry = Console.ReadLine();
                
                // Save the entry
                DateTime currentDate = DateTime.Now;
                string dateText = currentDate.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = randomPrompt;
                newEntry._entryText = myEntry;

                journal.AddEntry(newEntry);
            } 
            else if (userChoice == 2)
            {
                journal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveAsCSV(fileName);
            }
            else if (userChoice == 6)
            {
                Console.WriteLine("Well done for writing your journal!");
            }
            else
            {
                Console.WriteLine("Please input a valid number.");
            }
        }

    }
}