// Derived class for Simple Goals
[Serializable]
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
        return IsCompleted ? $"[X] {Name}" : $"[ ] {Name}";
    }
}