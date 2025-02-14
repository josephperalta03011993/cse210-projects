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
                    }
                break;

                // List goal
                case "2":
                    Console.WriteLine("\nThe goals are:");
                    goalManager.ListGoalDetails();
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