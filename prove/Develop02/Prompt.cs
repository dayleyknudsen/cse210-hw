public class Prompt
{
    private List<string> _prompts;

    public Prompt()
    {
        _prompts = new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Describe a moment when you felt grateful today.");
        _prompts.Add("Reflect on a challenge you encountered and how you overcame it.");
        _prompts.Add("Write about something that made you smile or laugh.");
        _prompts.Add("What is one thing you learned today?");
        _prompts.Add("Describe a random act of kindness you witnessed or performed.");
        _prompts.Add("Write about a goal you accomplished or progress you made towards a goal.");
        _prompts.Add("Reflect on a mistake you made and what you learned from it.");
        _prompts.Add("Share a memory from your past that brings you joy.");
        _prompts.Add("What are you looking forward to tomorrow?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}