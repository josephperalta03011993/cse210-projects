using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Starting Goal Manager...");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have not set a goal yet.");
        }
        else 
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the index of the goal you completed:");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < _goals.Count)
        {
            var goal = _goals[index];
            goal.RecordEvent();

            // Extract points from the string representation
            string[] parts = goal.GetStringRepresentation().Split(',');
            if (parts.Length >= 3 && int.TryParse(parts[2], out int points))
            {
                _score += points;
            }
            else
            {
                Console.WriteLine("Failed to add points. Invalid format.");
            }
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }


    public void SaveGoals(string fileName)
    {
        try
        {
            // Ensure the directory exists
            string directory = Path.GetDirectoryName(fileName);
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        _goals.Clear();

        using StreamReader reader = new StreamReader(filePath);
        _score = int.Parse(reader.ReadLine() ?? "0");

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split('|');
            string goalType = parts[0];

            switch (goalType)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3]));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                    break;

                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5])));
                    break;

                default:
                    Console.WriteLine("Unknown goal type found in file.");
                    break;
            }
        }
    }


} 
