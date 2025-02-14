public class LevelManager
{
    private int _level;
    private int _points;
    private int _nextLevelThreshold;

    public LevelManager(int initialPoints = 0)
    {
        _level = 1;
        _points = initialPoints;
        _nextLevelThreshold = 500;

        // Adjust level based on initial points
        while (_points >= _nextLevelThreshold)
        {
            _level++;
            _nextLevelThreshold += 500;
        }
    }

    public int Level => _level;
    public int Points => _points;

    public void AddPoints(int points)
    {
        _points += points;
        CheckLevelUp();
    }

    public void CheckLevelUp()
    {
        while (_points >= _nextLevelThreshold)
        {
            _level++;
             
            Console.WriteLine("\n===============================");
            Console.WriteLine($"LEVEL UP! You are now Level {_level}!");
            Console.WriteLine($"Next level at: {_nextLevelThreshold + 500} points.");
            Console.WriteLine("===============================\n");

            _nextLevelThreshold += 500;
        }
    }

    public string GetStatus()
    {
        return $"Level: {_level}, Points: {_points}/{_nextLevelThreshold}";
    }
} 
