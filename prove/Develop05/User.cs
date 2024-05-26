using System;
using System.Collections.Generic;
using System.IO;

public class User
{
    public List<Goal> Goals { get; private set; }
    public int Score { get; private set; }
    public int Level { get; private set; }
    private const int PointsPerLevel = 1000; 

    public List<int> Milestones { get; private set; }
    private const int MilestoneReward = 500; 

    public User()
    {
        Goals = new List<Goal>();
        Score = 0;
        Level = 1;
        Milestones = new List<int> { 5000, 10000, 15000 }; 
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = Goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            AddPoints(goal.Points);

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
            {
                AddPoints(checklistGoal.BonusPoints);
            }
        }
    }

    private void AddPoints(int points)
    {
        Score += points;
        Level = (Score / PointsPerLevel) + 1;

        CheckMilestones();
    }

    private void CheckMilestones()
    {
        foreach (var milestone in Milestones)
        {
            if (Score >= milestone)
            {
                Console.WriteLine($"Congratulations! You've reached {milestone} points and earned a bonus of {MilestoneReward} points!");
                Score += MilestoneReward;
                Milestones.Remove(milestone);
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.Display());
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(Score);
            writer.WriteLine(Level);

            foreach (var goal in Goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points},{goal.IsCompleted}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.CurrentCount},{checklistGoal.TargetCount},{checklistGoal.BonusPoints}");
                }
            }
        }
    }

   public void LoadGoals(string filePath)
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        Score = int.Parse(reader.ReadLine());
        Level = int.Parse(reader.ReadLine());

        Goals.Clear();

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split(',');

            Goal goal = null;
            switch (parts[0])
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(parts[1], int.Parse(parts[2]));
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(parts[1], int.Parse(parts[2]));
                    break;
               case "ChecklistGoal":
                    var checklistGoal = new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[4]), int.Parse(parts[5]));
                     checklistGoal.CurrentCount = int.Parse(parts[3]);
                    goal = checklistGoal;
                    break;
                case "NegativeGoal":
                    goal = new NegativeGoal(parts[1], int.Parse(parts[2]));
                    break;
            }
            if (goal != null)
            {
                Goals.Add(goal);
            }
        }
    }
}
}
