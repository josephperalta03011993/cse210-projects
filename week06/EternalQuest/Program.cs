using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while(running)
        {
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                // Create goal
                case "1":
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string typeOfGoal = Console.ReadLine();

                    switch(typeOfGoal)
                    {
                        // Simple Goal
                        case "1":
                            Console.Write("What is the name of your goal? ");
                            string goalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string goalDesc = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string goalPoints = Console.ReadLine();
                            goalManager.CreateGoal(new SimpleGoal(goalName, goalDesc, goalPoints));
                            break;
                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                        // Eternal Goal
                        case "2":
                            Console.Write("What is the name of your goal? ");
                            string eternalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string eternalDesc = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string eternalPoints = Console.ReadLine();
                            goalManager.CreateGoal(new EternalGoal(eternalName, eternalDesc, eternalPoints));
                            break;
                        // Checklist Goal
                        case "3":
                            Console.Write("What is the name of your goal? ");
                            string checklistName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string checklistDesc = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string checklistPoints = Console.ReadLine();
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int targetCount = int.Parse(Console.ReadLine() ?? "0");
                            Console.Write("What is the bonus for completing it that many times? ");
                            int bonusPoints = int.Parse(Console.ReadLine() ?? "0");
                            goalManager.CreateGoal(new ChecklistGoal(checklistName, checklistDesc, checklistPoints, targetCount, bonusPoints));
                            break;

                    }
                break;

                // List goal
                case "2":
                    Console.WriteLine("\nThe goals are:");
                    goalManager.ListGoalDetails();
                    break;

                // Save Goal
                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();

                    // Add txt extension if not provided
                    if (!Path.HasExtension(filename))
                    {
                        filename = Path.ChangeExtension(filename, ".txt");
                    }

                    // Create full path in a specific folder (optional)
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Goals", filename);

                    goalManager.SaveGoals(filePath);
                    Console.WriteLine($"Goal saved to {filePath}");
                    break;
                
                // Load Goals
                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string loadFilename = Console.ReadLine();
                    string loadFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Goals", loadFilename);
                    goalManager.LoadGoals(loadFilePath);
                    break;
                
                // Record Event
                case "5":
                    Console.WriteLine("The goals are:");
                    goalManager.ListGoalNames();
                    goalManager.RecordEvent();
                    break;
                
                // Quit
                case "6":
                    running = false;
                    Console.WriteLine("Great job setting your goals!");
                    break;
            }
        }
    }
}