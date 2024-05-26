public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never marked as complete
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points each time";
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName}";
    }
}
