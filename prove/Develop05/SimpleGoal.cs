// Derived class for Simple Goals
public class SimpleGoal : Goal
{
    public SimpleGoal() { }

    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string DisplayStatus()
    {
        return IsCompleted ? $"[X] {_name}" : $"[ ] {_name}";
    }
}
