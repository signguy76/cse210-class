// Derived class for Checklist Goals
[Serializable]
public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal() { }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsCompleted = true;
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string DisplayStatus()
    {
        return IsCompleted ? $"[X] {Name} (Completed {CurrentCount}/{TargetCount} times)" : $"[ ] {Name} (Completed {CurrentCount}/{TargetCount} times)";
    }
}