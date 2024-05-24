// Derived class for Eternal Goals
public class EternalGoal : Goal
{
    public EternalGoal() { }

    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string DisplayStatus()
    {
        return $"[∞] {_name}";
    }
}
