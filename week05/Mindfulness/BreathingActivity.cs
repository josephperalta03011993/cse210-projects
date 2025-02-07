public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity.",
        "This activity will help you relax by walking you through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.")
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.Write("\n\nBreath in... ");
            ShowCountDown(4); // pause
            Console.Write("\nBreath out... ");
            ShowCountDown(6); // pause
        }

        DisplayEndingMessage();
    }
}