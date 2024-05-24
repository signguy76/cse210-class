// Derived class for Checklist Goals
public class ChecklistGoal : Goal
{
    public int _target { get; set; }
    public int _amountCompleted { get; set; }
    public int _bonus { get; set; }

    public ChecklistGoal() { }

    public ChecklistGoal(string name, int points, int target, int bonusPoints)
        : base(name, points)
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                IsCompleted = true;
                return Points + _bonus;
            }
            return Points;
        }
        return 0;
    }

    public override string DisplayStatus()
    {
        return IsCompleted ? $"[X] {_name} (Completed {_amountCompleted}/{_target} times)" : $"[ ] {_name} (Completed {_amountCompleted}/{_target} times)";
    }
}
