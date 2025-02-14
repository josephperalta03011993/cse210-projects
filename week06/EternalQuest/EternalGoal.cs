public abstract class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) 
        : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for eternal goal: {_shortName}");
    }

    public override bool IsComplete()
    {
        return false; // should always be false
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }
}