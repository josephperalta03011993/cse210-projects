public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What is one thing I learned today?",
        "What am I grateful for today?",
        "What is a challenge I faced today, and how did I overcome it?",
        "If I could relive one moment from today, what would it be?",
        "What is something I did well today?",
        "What is one thing I could have done differently today?",
        "What am I looking forward to tomorrow?",
        "What is a goal I can work towards this week?"
    };

    public string GetRandomPrompt()
    {

        int randomPrompt = new Random().Next(_prompts.Count);
        return _prompts[randomPrompt];
    }
}