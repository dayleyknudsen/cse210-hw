public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = Prompts[rand.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        Pause(5);

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("List item: ");
            Console.ReadLine();
            itemCount++;
        }
        Console.WriteLine($"You listed {itemCount} items.");
    }
}
