// Base class for Goals
public abstract class Goal
{
    public string _name { get; set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public Goal() { }

    public Goal(string name, int points)
    {
        _name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract int RecordEvent();
    public abstract string DisplayStatus();
}
