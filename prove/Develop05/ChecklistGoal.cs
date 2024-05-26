public class ChecklistGoal : Goal
{
    public int CurrentCount { get; set; }
    public int TargetCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        CurrentCount = 0;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        IsCompleted = CurrentCount >= TargetCount;
    }

    public override string Display()
    {
        return $"[ {(IsCompleted ? "X" : " ")} ] {Name} - {Points} points (Completed {CurrentCount}/{TargetCount} times)";
    }
}
