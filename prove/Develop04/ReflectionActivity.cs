public class ReflectionActivity : MindfulnessActivity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions =
    {
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

    public ReflectionActivity()
    {
        _activityName = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = Prompts[rand.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        Pause(5);

        int secondsElapsed = 0;
        while (secondsElapsed < _duration)
        {
            string question = Questions[rand.Next(Questions.Length)];
            Console.WriteLine(question);
            Pause(5);
            secondsElapsed += 5;
        }
    }
}
