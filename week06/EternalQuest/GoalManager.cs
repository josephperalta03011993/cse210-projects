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


    public void SaveGoals(string filePath)
    {
        using StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine(_score);
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            _goals.Clear();
            using StreamReader reader = new StreamReader(filePath);
            _score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    var goal = new SimpleGoal(parts[0], parts[1], parts[2]);
                    if (bool.TryParse(parts[3], out bool isComplete) && isComplete)
                    {
                        goal.RecordEvent(); // Mark as complete if the saved state indicates so
                    }
                    _goals.Add(goal);
                }
            }
        }
    }

} 
