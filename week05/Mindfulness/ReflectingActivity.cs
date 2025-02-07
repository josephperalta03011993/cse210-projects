public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Enhancement tracked questions asked
    private List<string> _askedQuestions = new List<string>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect "+
                                "on times in your life when you have shown strength and resilience. "+
                                "This will help you recognize the power you have and how you can use it "+
                                "in other aspects of your life.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"\nConsider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        int questionsAskedCount = 0;
        while(questionsAskedCount * 30 < _duration)
        {
            DisplayQuestions();
            ShowSpinner(30);
            questionsAskedCount++;
        }
        
        _askedQuestions.Clear(); // clear the list for next turn
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        List<string> availableQuestions = new List<string>();

        // Find available questions without LINQ
        foreach (string question in _questions)
        {
            if (!_askedQuestions.Contains(question))
            {
                availableQuestions.Add(question);
            }
        }

        if (availableQuestions.Count == 0)
        {
            _askedQuestions.Clear();
            availableQuestions.AddRange(_questions); // Add all questions back
        }

        string selectedQuestion = availableQuestions[random.Next(availableQuestions.Count)];
        _askedQuestions.Add(selectedQuestion);
        return selectedQuestion;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"\n> {question} ");
    }
}