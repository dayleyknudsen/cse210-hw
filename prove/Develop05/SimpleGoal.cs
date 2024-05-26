public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
        }
    }

    public override string Display()
    {
        return $"[ {(IsCompleted ? "X" : " ")} ] {Name} - {Points} points";
    }

    public void MarkCompleted()
    {
        IsCompleted = true;
    }
}
