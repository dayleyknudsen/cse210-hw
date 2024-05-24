public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void RunActivity()
    {
        int secondsElapsed = 0;
        while (secondsElapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(4);
            Console.WriteLine("Breathe out...");
            Pause(4);
            secondsElapsed += 8;
        }
    }
}
