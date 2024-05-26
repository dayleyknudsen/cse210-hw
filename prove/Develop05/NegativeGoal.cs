public class NegativeGoal : Goal
{
    public NegativeGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
    }

    public override string Display()
    {
        return $"[ ] {Name} - {Points} points (negative)";
    }
}