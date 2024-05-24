using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName} activity...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Pause(3);
        
        RunActivity();
        
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You have completed {_activityName} for {_duration} seconds.");
        Pause(3);
    }

    protected abstract void RunActivity();

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
