public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity.",
        "This activity will help you relax by walking you through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.")
    {

    }
    public void Run()
    {

        /*
            The 4-7-8 breathing technique involves breathing in for 4 seconds, 
            holding the breath for 7 seconds, and exhaling for 8 seconds. 
            This breathing pattern aims to reduce anxiety or help people get to sleep.
            Lets try to do this but easier version.
            2-2-6
        */
        DisplayStartingMessage();
        
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.Write("\n\nBreath in... ");
            ShowCountDown(2); // pause
            Console.Write("\nHold for... ");
            ShowCountDown(2); // hold
            Console.Write("\nBreath out... ");
            ShowCountDown(6); // pause
        }

        DisplayEndingMessage();
    }
}