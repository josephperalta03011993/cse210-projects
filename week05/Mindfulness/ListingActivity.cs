public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();
        GetListFromUser();

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in:  ");
        ShowCountDown(5);
        Console.WriteLine();
    }

    public List<string> GetListFromUser()
    {
        _count = 0;
        List<string> userResponses = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string response = Console.ReadLine(); // User types and presses Enter for each item
            if(!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response);
                _count++;
            }
        }

        Console.WriteLine($"\nYou listed {_count} items!"); 

        return userResponses;
    }
}